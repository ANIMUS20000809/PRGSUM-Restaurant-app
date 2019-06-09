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
        #region Fields
        public const string ConnectionString = "Data Source=ANIMUS;Initial Catalog=Restaurant;Integrated Security=True";

        public static string Name { get; set; }

        public static string Table { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Tries to connect to the database 
        /// </summary>
        public static void Connect()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Database connected successfully!");
                    } 
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
