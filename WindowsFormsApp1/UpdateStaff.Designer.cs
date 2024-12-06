namespace WindowsFormsApp1
{
    partial class UpdateStaff
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
            this.StaffID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Reports_To = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateStaff_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffID
            // 
            this.StaffID.Location = new System.Drawing.Point(293, 71);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(121, 22);
            this.StaffID.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(293, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(293, 212);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(121, 22);
            this.Contact.TabIndex = 7;
            // 
            // Reports_To
            // 
            this.Reports_To.Location = new System.Drawing.Point(293, 284);
            this.Reports_To.Name = "Reports_To";
            this.Reports_To.Size = new System.Drawing.Size(121, 22);
            this.Reports_To.TabIndex = 8;
            // 
            // Designation
            // 
            this.Designation.Location = new System.Drawing.Point(293, 354);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(121, 22);
            this.Designation.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(56, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "District ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reports To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(56, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Designation";
            // 
            // UpdateStaff_Button
            // 
            this.UpdateStaff_Button.BackColor = System.Drawing.Color.Transparent;
            this.UpdateStaff_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateStaff_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.UpdateStaff_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UpdateStaff_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateStaff_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStaff_Button.ForeColor = System.Drawing.Color.White;
            this.UpdateStaff_Button.Location = new System.Drawing.Point(342, 450);
            this.UpdateStaff_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateStaff_Button.Name = "UpdateStaff_Button";
            this.UpdateStaff_Button.Size = new System.Drawing.Size(121, 30);
            this.UpdateStaff_Button.TabIndex = 21;
            this.UpdateStaff_Button.Text = "Update";
            this.UpdateStaff_Button.UseVisualStyleBackColor = false;
            this.UpdateStaff_Button.Click += new System.EventHandler(this.UpdateStaff_Button_Click);
            // 
            // UpdateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 529);
            this.Controls.Add(this.UpdateStaff_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.Reports_To);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.StaffID);
            this.Name = "UpdateStaff";
            this.Text = "Update Staff Information";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateStaff_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.TextBox Reports_To;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateStaff_Button;
    }
}