using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_App
{
    public class SessionContext
    {
        public enum SessionContextRole { Admin, Waiter, Customer };

        #region Fields
        public const string ConnectionString = "Data Source=ANIMUS;Initial Catalog=Restaurant;Integrated Security=True";

        public static SessionContextRole Role;
        public static string Waiter { get; set; }
        public static string Customer { get; set; }

        public static string[] customerNames { get; set; }
        public static string[] waiterNames { get; set; }
        #endregion

        #region Methods
        public static void refresh(SqlConnection con)
        {
            using (SqlCommand wNames = new SqlCommand())
            {
                wNames.Connection = con;
                wNames.CommandText = "SELECT [Waiter name] FROM Waiters";
                using (SqlDataReader reader = wNames.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader[1].ToString());
                            waiterNames.Append(reader["Waiter name"].ToString()); 
                        }
                    }
                }

            }

            using (SqlCommand cNames = new SqlCommand())
            {
                cNames.Connection = con;
                cNames.CommandText = "SELECT Name FROM Customers";

                using (SqlDataReader reader = cNames.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            customerNames.Append(reader["Name"].ToString());
                        }
                    }
                }
            }


        }

        public static void update()
        {
            Cursor.Current = Cursors.WaitCursor;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Database connected successfully!");
                        refresh(con);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
