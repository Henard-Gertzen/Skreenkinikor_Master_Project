using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Skreenkinikor_Master_Project.Classes
{
    public struct totalMovies
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Reports_Class
    {
        //Private variables
        private DateTime startDate, endDate;
        private int numDays;
        //Public Variables
        public List<totalMovies> lTotalMovies { get; private set; }
        public List<KeyValuePair<string, int>> lTop10Movies {get; private set;}

        private void TotalMovies(DateTime startDate, DateTime endDate)
        {
            lTotalMovies = new List<totalMovies>();

            using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
            {
                con.Open();
                string sqlTotal = @"SELECT Day_Shown, COUNT(DISTINCT Movie_On_Schedule.Movie_ID) AS TotalMovies
                            FROM Schedule
                            INNER JOIN Movie_On_Schedule ON Schedule.Schedule_ID = Movie_On_Schedule.Schedule_ID
                            WHERE Schedule.Day_Shown BETWEEN @StartDate AND @EndDate
                            GROUP BY Schedule.Day_Shown
                            ORDER BY Schedule.Day_Shown";
                using (SqlCommand cmd = new SqlCommand(sqlTotal, con))
                {
                    cmd.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = endDate;

                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1]));
                        }
                    }
                    if (numDays <= 30)
                    {
                        lTotalMovies = (from orderList in resultTable
                                        group orderList by orderList.Key.ToString("dd MMM")
                                        into order
                                        select new totalMovies
                                        {
                                            Date = order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                    else
                    {
                        lTotalMovies = (from orderList in resultTable
                                        group orderList by orderList.Key.ToString("yyyy")
                                        into order
                                        select new totalMovies
                                        {
                                            Date = order.Key,
                                            TotalAmount= order.Sum(amount => amount.Value)
                                        }).ToList();
                    }
                }
            }
        }

        private void Top10Movies(DateTime startDate, DateTime endDate)
        {
            lTop10Movies = new List<KeyValuePair<string, int>>();
            using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
            {
                con.Open();
                string sqlTop10 = @"SELECT TOP 10 Movie_Info.Movie_Name, SUM(Ticket_Info.Ticket_Total) AS TotalSales
                                    FROM Movie_Info
                                    INNER JOIN Ticket_Info ON Movie_Info.Movie_ID = Ticket_Info.Movie_ID
                                    WHERE Ticket_Info.Ticket_ID IN(
                                    SELECT Ticket_ID
                                    FROM Schedule
                                    INNER JOIN Movie_On_Schedule ON Schedule.Schedule_ID = Movie_On_Schedule.Schedule_ID
                                    WHERE Schedule.Day_Shown BETWEEN '2000-01-01' AND '2023-12-31'
                                    )
                                    GROUP BY Movie_Info.Movie_Name
                                    ORDER BY TotalSales DESC";
                using(SqlCommand cmd = new SqlCommand(sqlTop10, con))
                {
                    cmd.Parameters.Add("@StartDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    cmd.Parameters.Add("@EndDate", System.Data.SqlDbType.DateTime).Value = endDate;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lTop10Movies.Add(new KeyValuePair<string, int>(reader[0].ToString(), Convert.ToInt32(reader[1])));
                        }
                    }
                }
            }
        }

        public bool LoadMovieData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if(startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numDays = (endDate - startDate).Days;

                TotalMovies(startDate, endDate);
                Top10Movies(startDate, endDate);
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());

                return true;
            }
            else
            {
                Console.WriteLine("Data Not Refreshed: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
