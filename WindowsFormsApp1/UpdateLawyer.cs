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
    public partial class UpdateLawyer : Form
    {
        public UpdateLawyer()
        {
            InitializeComponent();
        }

        private void Update_Lawyer_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdatePrisoner f1 = new UpdatePrisoner();
            f1.Show();
        }

        private void UpdateLawyer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            UpdatePrisoner f1 = new UpdatePrisoner();
            f1.Show();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdatePrisoner f1 = new UpdatePrisoner();
            f1.Show();
        }
    }
}
