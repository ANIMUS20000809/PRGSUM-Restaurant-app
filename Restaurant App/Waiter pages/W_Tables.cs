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
    public partial class W_Tables : Form
    {
        public W_Tables()
        {
            InitializeComponent();
        }

        #region Methods
        private void selectTable(string table)
        {
            SessionContext.Table = table;
            W_Spec s = new W_Spec();
            s.ShowDialog();
        }
        #endregion
        private void Button1_Click(object sender, EventArgs e)
        {
            selectTable(button1.Text);
        }
    }
}
