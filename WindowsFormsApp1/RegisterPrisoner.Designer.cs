namespace WindowsFormsApp1
{
    partial class RegisterPrisoner
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register_Prisoner_Button = new System.Windows.Forms.Button();
            this.PrisonerID_TextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Prisoner_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(78, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prisoner ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(78, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(78, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(78, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date Of Birth";
            // 
            // Register_Prisoner_Button
            // 
            this.Register_Prisoner_Button.BackColor = System.Drawing.Color.Transparent;
            this.Register_Prisoner_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Register_Prisoner_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Register_Prisoner_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Register_Prisoner_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register_Prisoner_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Prisoner_Button.ForeColor = System.Drawing.Color.White;
            this.Register_Prisoner_Button.Location = new System.Drawing.Point(423, 343);
            this.Register_Prisoner_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register_Prisoner_Button.Name = "Register_Prisoner_Button";
            this.Register_Prisoner_Button.Size = new System.Drawing.Size(80, 30);
            this.Register_Prisoner_Button.TabIndex = 25;
            this.Register_Prisoner_Button.Text = "Register";
            this.Register_Prisoner_Button.UseVisualStyleBackColor = false;
            this.Register_Prisoner_Button.Click += new System.EventHandler(this.Register_Prisoner_Button_Click);
            // 
            // PrisonerID_TextBox
            // 
            this.PrisonerID_TextBox.Font = new System.Drawing.Font("CMU Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrisonerID_TextBox.Location = new System.Drawing.Point(286, 194);
            this.PrisonerID_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrisonerID_TextBox.Multiline = true;
            this.PrisonerID_TextBox.Name = "PrisonerID_TextBox";
            this.PrisonerID_TextBox.Size = new System.Drawing.Size(217, 24);
            this.PrisonerID_TextBox.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("CMU Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(286, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 24);
            this.textBox1.TabIndex = 26;
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Font = new System.Drawing.Font("CMU Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_TextBox.Location = new System.Drawing.Point(286, 124);
            this.FirstName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstName_TextBox.Multiline = true;
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(217, 24);
            this.FirstName_TextBox.TabIndex = 27;
            // 
            // Prisoner_DateOfBirth
            // 
            this.Prisoner_DateOfBirth.Location = new System.Drawing.Point(286, 275);
            this.Prisoner_DateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.Prisoner_DateOfBirth.Name = "Prisoner_DateOfBirth";
            this.Prisoner_DateOfBirth.Size = new System.Drawing.Size(217, 22);
            this.Prisoner_DateOfBirth.TabIndex = 28;
            // 
            // RegisterPrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 407);
            this.Controls.Add(this.Prisoner_DateOfBirth);
            this.Controls.Add(this.FirstName_TextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PrisonerID_TextBox);
            this.Controls.Add(this.Register_Prisoner_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "RegisterPrisoner";
            this.Text = "Register Prisoner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterPrisoner_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Register_Prisoner_Button;
        private System.Windows.Forms.TextBox PrisonerID_TextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.DateTimePicker Prisoner_DateOfBirth;
    }
}