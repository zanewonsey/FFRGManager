using CommonUtil;
using FFRGManagerService.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FFRGManagerService.Database
{
    public class DBAccess
    {
#if DEBUG
        static string connectionString = "Server=.\\SQLEXPRESS;Database=FFRGBPOMGR;User Id=zanewonsey;Password=homeworkPW1;";
#else
        static string connectionString = "Server=.\\SQLEXPRESS;Database=FFRGBPOMGR;User Id=zwonsey;Password=Dematic800!;";
#endif

        public static string errormeme = "";

        public static string ConnectionTest()
        {
            string result = "zanetest";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "SELECT * FROM  [FFRGBPOMGR].[dbo].[Addresses]";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        result = "well it had rows";
                    }
                    else
                    {
                        result = "did not have rows";
                    }
                }
                catch (Exception e)
                {
                    result = e.ToString();
                }
            }
            return result;
        }

        private static List<string> GetAddressFromTableWithKey(int addrTblPKey)
        {
            List<string> resultList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM  [FFRGBPOMGR].[dbo].[Addresses]" +
                        " where Address_ID="+ addrTblPKey;
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        resultList.Add(reader["Street"].ToString().Trim());
                        resultList.Add(reader["City"].ToString().Trim());
                        resultList.Add(reader["State"].ToString().Trim());
                        resultList.Add(reader["ZipCode"].ToString().Trim());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return resultList;
        }

        private static int GetAddressTableKey(string Street, string City, string State, string zipcode)
        {
            int addrIndex = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM  [FFRGBPOMGR].[dbo].[Addresses]" +
                        " where (Street='" + Street +
                          "' AND City='" + City +
                          "' AND State='" + State +
                          "' AND ZipCode='" + zipcode + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        addrIndex = Int32.Parse(reader["Address_ID"].ToString().Trim());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return addrIndex;
        }

        private static int InsertAddressTable(string Street, string City, string State, string zipcode)
        {
            int addrIndex = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "INSERT INTO [FFRGBPOMGR].[dbo].[Addresses] (Street, City, State, ZipCode, MapCoordinates_ID, Year_Built)"
                        + "VALUES('" + Street + "', '" + City + "', '" + State + "', '" + zipcode + "', 1, '1920'); ";
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                finally
                {
                    addrIndex = GetAddressTableKey(Street, City, State, zipcode);
                }
            }

            return addrIndex;
        }

        public static bool AddOrder(Order order)
        {
            bool bSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // InsertAddressTable will return the PK of either the newly created entry
                    int addrIndex = GetAddressTableKey(order.GetStreet(), order.GetCity(), order.GetState(), order.GetZipcode());
                    if (addrIndex == -1)
                    {
                        addrIndex = InsertAddressTable(order.GetStreet(), order.GetCity(), order.GetState(), order.GetZipcode());
                    }

                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("MM-dd-yyyy HH:mm:ss.fff");

                    string queryString = "INSERT INTO [FFRGBPOMGR].[dbo].[Orders] (Address_ID, SourceCompany_ID, Due_Date, PicStatus)"
                                + "VALUES(" + addrIndex + ", 1, CONVERT(datetime,'" + sqlFormattedDate + "', 101), "+order.GetPictureStatusInt()+"); ";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                    bSuccess = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    errormeme = e.ToString();
                }
            }


            return bSuccess;
        }

        public static bool UpdateOrder(Order order)
        {
            bool bSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // InsertAddressTable will return the PK of either the newly created entry
                    int addrIndex = GetAddressTableKey(order.GetStreet(), order.GetCity(), order.GetState(), order.GetZipcode());
                    if (addrIndex == -1)
                    {
                        addrIndex = InsertAddressTable(order.GetStreet(), order.GetCity(), order.GetState(), order.GetZipcode());
                    }

                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("MM-dd-yyyy HH:mm:ss.fff");

                    string queryString = "UPDATE [FFRGBPOMGR].[dbo].[Orders] " +
                        "SET " +
                        " Notes = '" + order.GetOrderDetails()+"'"+
                        " where Order_ID=" + order.GetOrderID();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                    bSuccess = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }


            return bSuccess;
        }

        public static bool DeleteOrder(Order order)
        {
            bool bSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "DELETE FROM [FFRGBPOMGR].[dbo].[Orders] where Order_ID="+order.GetOrderID();

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                    bSuccess = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            return bSuccess;
        }

        public static List<Order> OrdersList()
        {
            List<Order> l_orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT *  FROM  [FFRGBPOMGR].[dbo].[Orders]";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = null;
                try
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        List<string> orderAddr = GetAddressFromTableWithKey(Int32.Parse(reader["Address_ID"].ToString().Trim()));
                        l_orders.Add(new Order(orderAddr[0],
                                               orderAddr[1],
                                               orderAddr[2],
                                               orderAddr[3],
                                               Int32.Parse(reader["Order_ID"].ToString().Trim())
                                              )
                            );
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return l_orders;
        }




        public static StylistProfile StylistProfileDB(string queryString, string guid)
        {
            StylistProfile s_sp = new StylistProfile();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    s_sp = new StylistProfile(reader["GUID"].ToString().Trim(),
                                              reader["FirstName"].ToString().Trim(),
                                              reader["LastName"].ToString().Trim(),
                                              reader["Salon"].ToString().Trim(),
                                       (float)reader["Lat"],
                                       (float)reader["Long"],
                                              reader["City"].ToString().Trim()
                                             );
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return s_sp;
        }

        public static List<StylistProfile> DBStuff(string queryString)
        {
            List<StylistProfile> l_sp = new List<StylistProfile>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                connection.Open();
                SqlDataReader reader = null;
                try
                {
                    reader = command.ExecuteReader();
                
                    while (reader.Read())
                    {
                        l_sp.Add(new StylistProfile(reader["GUID"].ToString().Trim(),
                                                    reader["FirstName"].ToString().Trim(),
                                                    reader["LastName"].ToString().Trim(),
                                                    reader["Salon"].ToString().Trim(),
                                             (float)reader["Lat"],
                                             (float)reader["Long"],
                                                    reader["City"].ToString().Trim()
                                                    )
                            );
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("uwu I made a fucky: " + e.ToString());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            return l_sp;
        }
    }
}
