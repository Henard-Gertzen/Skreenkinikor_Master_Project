﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows;

namespace Skreenkinikor_Master_Project.Classes
{
    public struct totalMovies
    {
        public string Date { get; set; }
        public int TotalAmount { get; set; }
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
            try
            {
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
                            while (reader.Read())
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
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
            }
            
        }

        private void Top10Movies(DateTime startDate, DateTime endDate)
        {
            lTop10Movies = new List<KeyValuePair<string, int>>();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionStrings.conSkreenMainStr))
                {
                    con.Open();
                    string sqlTop10 = @"SELECT TOP 10 MI.Movie_Name, SUM(Ticket_Info.Ticket_Total) AS total
                                    FROM Ticket_Info
                                    INNER JOIN Movie_Info MI ON MI.Movie_ID = Ticket_Info.Movie_ID
                                    INNER JOIN Movie_On_Schedule MOS ON MOS.Movie_ID = MI.Movie_ID
                                    WHERE Payment_Date BETWEEN @StartDate AND @EndDate
                                    GROUP BY MI.Movie_Name
                                    ORDER BY total DESC";
                    using (SqlCommand cmd = new SqlCommand(sqlTop10, con))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex);
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
