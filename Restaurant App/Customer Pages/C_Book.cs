using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_App
{
    public partial class C_Book : Form
    {
        public C_Book()
        {
            InitializeComponent();
            textBox1.Text = "1";
        }

        #region Methods
        /// <summary>
        /// Booking the selected table
        /// </summary>
        /// <param name="table"> The number of the table being booked</param>
        private void Book(string table, object s)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (s is Control)
                {
                    Control c = (Control)s;

                    if (c.BackColor == Color.Lime)
                    {
                        if (MessageBox.Show("Are you sure you want to book?\n" +
                                            $"Name: {SessionContext.Name}\n" +
                                            $"Date: {dateTimePicker1.Value}\n" +
                                            $"Number of people: {textBox1.Text}\n" +
                                            $"Table: {table}",
                                            "Confirmation",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            // TODO: Save booking to database
                            using (SqlConnection con = new SqlConnection(SessionContext.ConnectionString))
                            {
                                con.Open();

                                if (con.State == ConnectionState.Open)
                                {
                                    try
                                    {
                                        using (SqlCommand com = new SqlCommand($"INSERT INTO Booking(CustID, Date, [Number of people], [Checked in], TableID) VALUES({SessionContext.ID}, '{dateTimePicker1.Value}', {Convert.ToInt32(textBox1.Text)}, 'False', '{table}')", con))
                                        {
                                            com.ExecuteNonQuery();
                                            c.BackColor = Color.Red;
                                            MessageBox.Show("Table Booked successfully!", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    catch (SqlException sEx)
                                    {
                                        MessageBox.Show(sEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    catch (FormatException FeX)
                                    {
                                        MessageBox.Show(FeX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("This table is already booked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the number of people", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            fillData(dateTimePicker1.Value);
        }
        /// <summary>
        /// Fills the booking data from the bookings table
        /// </summary>
        /// <param name="dt">The DateTime value of the DatePicker</param>
        public void fillData(DateTime dt)
        {
            // TODO: Fill in the booking data
            try
            {
                using (SqlConnection con = new SqlConnection(SessionContext.ConnectionString))
                {
                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        using (SqlCommand com = new SqlCommand($"SELECT Date, TableID FROM Booking WHERE Date = '{dt.ToString()}'", con))
                        {
                            using (SqlDataReader rd = com.ExecuteReader())
                            {
                                if (rd.HasRows)
                                {
                                    while (rd.Read())
                                    {
                                        switch (Convert.ToInt32(rd["TableID"]))
                                        {
                                            case 1:
                                                button1.BackColor = Color.Red;
                                                break;
                                            case 2:
                                                button2.BackColor = Color.Red;
                                                break;
                                            case 3:
                                                button3.BackColor = Color.Red;
                                                break;
                                            case 4:
                                                button4.BackColor = Color.Red;
                                                break;
                                            case 5:
                                                button5.BackColor = Color.Red;
                                                break;
                                            case 6:
                                                button6.BackColor = Color.Red;
                                                break;
                                            case 7:
                                                button7.BackColor = Color.Red;
                                                break;
                                            case 8:
                                                button8.BackColor = Color.Red;
                                                break;
                                            case 9:
                                                button9.BackColor = Color.Red;
                                                break;
                                            case 10:
                                                button10.BackColor = Color.Red;
                                                break;
                                            case 11:
                                                button11.BackColor = Color.Red;
                                                break;
                                            case 12:
                                                button12.BackColor = Color.Red;
                                                break;
                                            case 13:
                                                button13.BackColor = Color.Red;
                                                break;
                                            case 14:
                                                button14.BackColor = Color.Red;
                                                break;
                                            case 15:
                                                button15.BackColor = Color.Red;
                                                break;
                                            case 16:
                                                button16.BackColor = Color.Red;
                                                break;
                                            case 17:
                                                button17.BackColor = Color.Red;
                                                break;
                                            case 18:
                                                button18.BackColor = Color.Red;
                                                break;
                                            case 19:
                                                button19.BackColor = Color.Red;
                                                break;
                                            case 20:
                                                button20.BackColor = Color.Red;
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    Reset();
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException sEx)
            {
                MessageBox.Show(sEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resets all of the table colors
        /// </summary>
        private void Reset()
        {
            button1.BackColor = Color.Lime;
            button2.BackColor = Color.Lime;
            button3.BackColor = Color.Lime;
            button4.BackColor = Color.Lime;
            button5.BackColor = Color.Lime;
            button6.BackColor = Color.Lime;
            button7.BackColor = Color.Lime;
            button8.BackColor = Color.Lime;
            button9.BackColor = Color.Lime;
            button10.BackColor = Color.Lime;
            button11.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;
            button13.BackColor = Color.Lime;
            button14.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;
            button16.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;
            button19.BackColor = Color.Lime;
            button20.BackColor = Color.Lime;
        }
        #endregion

        #region Event Handlers
        private void Button1_Click(object sender, EventArgs e)
        {
            Book(button1.Text, sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Book(button2.Text, sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Book(button3.Text, sender);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Book(button4.Text, sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Book(button5.Text, sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Book(button6.Text, sender);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Book(button7.Text, sender);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Book(button8.Text, sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Book(button9.Text, sender);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Book(button10.Text, sender);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Book(button11.Text, sender);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Book(button12.Text, sender);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Book(button13.Text, sender);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Book(button14.Text, sender);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Book(button15.Text, sender);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Book(button16.Text, sender);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Book(button17.Text, sender);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Book(button18.Text, sender);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Book(button19.Text, sender);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Book(button20.Text, sender);
        }

        private void C_Book_Load(object sender, EventArgs e)
        {
            fillData(dateTimePicker1.Value);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fillData(dateTimePicker1.Value);
        }
        #endregion


    }
}
