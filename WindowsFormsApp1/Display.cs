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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }


        private void Display_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            District_Police_Database f1 = new District_Police_Database();
            f1.Show();
        }

        private void Prisoners_Insert_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterPrisoner f2 = new RegisterPrisoner();
            f2.ShowDialog();
        }

        private void Staff_Display_Button_Click(object sender, EventArgs e)
        {
            Display_Box.Visible = true;
        }

        private void Staff_Delete_Button_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void Staff_Update_Button_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateStaff a = new UpdateStaff();
            a.Show();
        }

        private void Staff_Insert_Button_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            InsertStaff f2 = new InsertStaff();
            f2.ShowDialog();
        }

        private void Prisoners_Display_Button_Click_1(object sender, EventArgs e)
        {
            Display_Box.Visible = true;

        }

        private void Prisoners_Update_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdatePrisoner f1 = new UpdatePrisoner();
            f1.Show();
        }

        private void Register_Prisoner_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterPrisoner f1 = new RegisterPrisoner();
            f1.Show();
        }
    }
}
