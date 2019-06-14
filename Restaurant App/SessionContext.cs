using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant_App
{
    public class SessionContext
    {
        #region Fields
        public const string ConnectionString = "Data Source=ANIMUS\\MYSERVER;Initial Catalog=Restaurant;Integrated Security=True";

        public static string Name { get; set; }

        public static string Table { get; set; }

        public static int ID { get; set; }

        public static int bookRowCount { get; set; }

        public static int orderRowCount { get; set; }

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