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
    public partial class UpdateCrime : Form
    {
        public UpdateCrime()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Other")
            {
                groupBox1.Visible = true;

            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterPrisoner f1 = new RegisterPrisoner();
            f1.Show();
        }
    }
}
