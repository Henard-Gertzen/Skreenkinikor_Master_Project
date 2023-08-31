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
        private DateTime startDate, endDate;
        private int numDays;

        public int numTickets { get; private set; }
        public int numTotalMoviesScheduled { get; private set; }
        public List<TotalMoviesScheduled> TotalMovies { get; private set; }
        public List<KeyValuePair<string, decimal>> top10Movies { get; private set; }

        //Constructor
        public ReportsClass()
        {

        }
        //Private Methods
        private void GetTotalMoviesScheduled()
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
            top10Movies = new List<KeyValuePair<string, decimal>>();

            using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
            {
                con.Open();
                SqlDataReader reader;
                string sqlCmd = @"SELECT TOP 10 MI.Movie_Name, SUMS(Ticket_Info.TicketTotal) AS totalSales
                                            FROM Movie_Info AS MI
                                            INNER JOIN Movie_On_Schedule AS MOS ON MI.Movie_ID = MOS.Movie_ID
                                            INNER JOIN Schedule AS S ON MOS.Schedule_ID = S.Schedule_ID
                                            INNER JOIN Ticket_Info AS TI ON MI.Movie_ID = TI.Movie_ID
                                            WHERE S.Day_Shown BETWEEN @StartDate AND @EndDate
                                            GROUP BY MI.Movie_Name
                                            ORDER BY totalSales DESC";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, con))
                {
                    cmd.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = dateStart;
                    cmd.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = dateEnd;

                    reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        top10Movies.Add(new KeyValuePair<string, decimal>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        //Public methods
        public void LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if(startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numDays = (endDate - startDate).Days;

                GetTotalMoviesScheduled();
                GetTop10Movies();
            }
        }
    }
}
