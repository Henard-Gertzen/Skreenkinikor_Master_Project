using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skreenkinikor_Master_Project.Classes;
using System.Globalization;

namespace Skreenkinikor_Master_Project.Classes
{
    public struct TotalMoviesScheduled
    {
        public string Date { get; set; }
        public int totalMovies { get; set; }
    }
    public class ReportsClass
    {
        //Fields
        private DateTime dateStart, dateEnd;
        private int numDays;

        public int numTickets { get; private set; }
        public int numTotalMoviesScheduled { get; private set; }
        public List<TotalMoviesScheduled> TotalMovies { get; private set; }
        public List<TotalMoviesScheduled> top10Movies { get; private set; }

        //Constructor
        public ReportsClass()
        {

        }
        //Methods
        private void getNumMovies()
        {
            TotalMovies = new List<TotalMoviesScheduled>();
            using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
            {
                con.Open();
                string sqlTotalMovies = @"SELECT Schedule.Day_Shown, COUNT(Movie_ID FROM [Movie_On_Schedule] 
                                        INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID
                                        WHERE Schedule.Day_Shown BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(sqlTotalMovies, con))
                {
                    cmd.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = dateStart;
                    cmd.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = dateEnd;
                    SqlDataReader reader = cmd.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while(reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1]));
                    }
                    reader.Close();

                    //Group by days
                    if(numDays <= 30)
                    {
                        foreach(var movie in resultTable)
                        {
                            TotalMovies.Add(new TotalMoviesScheduled()
                            {
                                Date = movie.Key.ToString("dd MM"),
                                totalMovies = movie.Value
                            });
                        }
                    }
                    //Group by Weeks
                    else if (numDays <= 92)
                    {
                        TotalMovies = (from oList in resultTable
                                       group oList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                       oList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                       into movie
                                       select new TotalMoviesScheduled
                                       {
                                           Date = "Week" + movie.Key.ToString(),
                                           totalMovies = movie.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                    //Group by Months
                    else if(numDays <= (365 * 2))
                    {
                        bool isYr = numDays <= 365 ? true : false;
                        TotalMovies = (from oList in resultTable
                                       group oList by oList.Key.ToString("MMM yyyy")
                                       into movie
                                       select new TotalMoviesScheduled
                                       {
                                           Date = isYr ? movie.Key.Substring(0, movie.Key.IndexOf(" ")) : movie.Key,
                                           totalMovies = movie.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                    //Group by Year
                    else
                    {
                        TotalMovies = (from oList in resultTable
                                       group oList by oList.Key.ToString("yyyy")
                                       into movie
                                       select new TotalMoviesScheduled
                                       {
                                           Date = movie.Key,
                                           totalMovies = movie.Sum(amount => amount.Value)
                                       }).ToList();
                    }
                }
            }
        }

        public void GetTop10Movies()
        {
            top10Movies = new List<TotalMoviesScheduled>();

            using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
            {
                con.Open();

                string sqlCmd = @"
                            SELECT Movie_On_Schedule.Movie_ID, COUNT(Ticket_Info.Ticket_ID) AS TotalTickets
                            FROM Movie_On_Schedule
                            INNER JOIN Schedule ON Movie_On_Schedule.Schedule_ID = Schedule.Schedule_ID
                            INNER JOIN Ticket_Info ON Movie_On_Schedule.Movie_ID = Ticket_Info.Movie_ID
                            WHERE Schedule.Day_Shown BETWEEN @StartDate AND @EndDate
                            GROUP BY Schedule.Day_Shown
                            ORDER BY TotalTickets DESC";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                {
                    cmd.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = dateStart;
                    cmd.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = dateEnd;
                    
                }
            }
        }
    }
}
