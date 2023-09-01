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
                    if(numDays <= 30)
                    {
                        lTotalMovies = ((List<totalMovies>)(from orderList in resultTable
                                        group orderList by orderList.Key.ToString("dd MMM")
                                        into order
                                        select new totalMovies
                                        {
                                            Date = order.Key,
                                            TotalAmount = order.Sum(amount => amount.Value)
                                        }));
                    }
                    else
                    {
                        lTotalMovies = ((List<totalMovies>) from orderList in resultTable
                                        group orderList by orderList.Key.ToString("yyyy")
                                        into order
                                        select new totalMovies
                                        {
                                            Date = order.Key,
                                            TotalAmount= order.Sum(amount => amount.Value)
                                        });
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


                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
