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
    public partial class District_Police_Database : Form
    {
        public District_Police_Database()
        {
            InitializeComponent();
            DBConnection c = new DBConnection();
            DataTable d = c.Select("select DistrictID, DistrictName from District_Jail");
            District_ID.DataSource = d;
            District_ID.DisplayMember = "DistrictName";
            District_ID.ValueMember = "DistrictID";
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            DBConnection c = new DBConnection();
            DataTable d = c.Select("select Password_Access from District_Jail where DistrictID = " + District_ID.ValueMember);
            if (d.Rows[0].Field<string>(0) == Password.Text)
            {
                MessageBox.Show("Login Successful");
                this.Visible = false;
                Display a = new Display();
                a.Show();
            }
            else
            {
                MessageBox.Show("Password Incorrect");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
