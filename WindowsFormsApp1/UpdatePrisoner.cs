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
    public partial class UpdatePrisoner : Form
    {
        public UpdatePrisoner()
        {
            InitializeComponent();
        }

        private void UpdatePrisoner_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Display f1 = new Display();
            f1.Show();

        }



        private void UpdateLawyer_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateLawyer f1 = new UpdateLawyer();
            f1.Show();

        }

        private void UpdateTrial_Button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateTrial f1 = new UpdateTrial();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateCrime f1 = new UpdateCrime();
            f1.Show();

        }

        private void Close_Button_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Display f1 = new Display();
            f1.Show();
        }
    }
}
