using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InsertStaff : Form
    {
        public InsertStaff()
        {
            InitializeComponent();
        }

        private void InsertStaff_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Display f2 = new Display();
            f2.ShowDialog();
        }

        private void InsertStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Display f1 = new Display();
            f1.Show();
        }

        private void Designation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
