using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_App
{
    public partial class C_Book : Form
    {
        public C_Book()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Booking the selected table
        /// </summary>
        /// <param name="table"> The number of the table being booked</param>
        private void Book(string table)
        {
            if (MessageBox.Show("Are you sure you want to book", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                // TODO: Save booking to database
                MessageBox.Show("Table Booked!");
            }
            fillData(dateTimePicker1.Value);
        }
        /// <summary>
        /// Fills the booking data from the bookings table
        /// </summary>
        /// <param name="dt">The DateTime of the DatePicker</param>
        public void fillData(DateTime dt)
        {
            // TODO: Fill the booking data
        }
        #endregion

        #region Event Handlers
        private void Button1_Click(object sender, EventArgs e)
        {
            Book(button1.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Book(button2.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Book(button3.Text);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Book(button4.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Book(button5.Text);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Book(button6.Text);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Book(button7.Text);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Book(button8.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Book(button9.Text);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Book(button10.Text);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Book(button11.Text);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Book(button12.Text);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Book(button13.Text);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Book(button14.Text);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Book(button15.Text);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            Book(button16.Text);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Book(button17.Text);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Book(button18.Text);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Book(button19.Text);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            Book(button20.Text);
        }

        #endregion

        
    }
}
