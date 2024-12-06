namespace WindowsFormsApp1
{
    partial class UpdateLawyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Date_Of_Appointment = new System.Windows.Forms.DateTimePicker();
            this.State_Appointed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date_Of_Appointment
            // 
            this.Date_Of_Appointment.Location = new System.Drawing.Point(324, 148);
            this.Date_Of_Appointment.Name = "Date_Of_Appointment";
            this.Date_Of_Appointment.Size = new System.Drawing.Size(183, 22);
            this.Date_Of_Appointment.TabIndex = 8;
            // 
            // State_Appointed
            // 
            this.State_Appointed.FormattingEnabled = true;
            this.State_Appointed.Location = new System.Drawing.Point(324, 244);
            this.State_Appointed.Name = "State_Appointed";
            this.State_Appointed.Size = new System.Drawing.Size(183, 24);
            this.State_Appointed.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("CMU Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(324, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 24);
            this.textBox1.TabIndex = 27;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(47, 148);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(190, 24);
            this.label.TabIndex = 28;
            this.label.Text = "Date Of Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(47, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date Of Appointment";
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.Color.Transparent;
            this.Update_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Update_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Update_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.Location = new System.Drawing.Point(427, 342);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(80, 30);
            this.Update_Button.TabIndex = 30;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // UpdateLawyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 415);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.State_Appointed);
            this.Controls.Add(this.Date_Of_Appointment);
            this.Name = "UpdateLawyer";
            this.Text = "Update Lawyer Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateLawyer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Date_Of_Appointment;
        private System.Windows.Forms.ComboBox State_Appointed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update_Button;
    }
}