namespace WindowsFormsApp1
{
    partial class Display
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
            this.Display_Box = new System.Windows.Forms.GroupBox();
            this.Staff = new System.Windows.Forms.GroupBox();
            this.Staff_Delete_Button = new System.Windows.Forms.Button();
            this.Staff_Display_Button = new System.Windows.Forms.Button();
            this.Prsoners_Box = new System.Windows.Forms.GroupBox();
            this.Staff_Update_Button = new System.Windows.Forms.Button();
            this.Staff_Insert_Button = new System.Windows.Forms.Button();
            this.Prisoners_Display_Button = new System.Windows.Forms.Button();
            this.Prisoners_Update_Button = new System.Windows.Forms.Button();
            this.Register_Prisoner_Button = new System.Windows.Forms.Button();
            this.Staff.SuspendLayout();
            this.Prsoners_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display_Box
            // 
            this.Display_Box.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.Display_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Display_Box.Location = new System.Drawing.Point(95, 46);
            this.Display_Box.Name = "Display_Box";
            this.Display_Box.Size = new System.Drawing.Size(436, 637);
            this.Display_Box.TabIndex = 0;
            this.Display_Box.TabStop = false;
            this.Display_Box.Text = "Display";
            this.Display_Box.Visible = false;
            // 
            // Staff
            // 
            this.Staff.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Staff.Controls.Add(this.Staff_Insert_Button);
            this.Staff.Controls.Add(this.Staff_Update_Button);
            this.Staff.Controls.Add(this.Staff_Delete_Button);
            this.Staff.Controls.Add(this.Staff_Display_Button);
            this.Staff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Staff.Location = new System.Drawing.Point(691, 46);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(373, 324);
            this.Staff.TabIndex = 1;
            this.Staff.TabStop = false;
            this.Staff.Text = "Staff";
            // 
            // Staff_Delete_Button
            // 
            this.Staff_Delete_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Delete_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Delete_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Staff_Delete_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Staff_Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Delete_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Staff_Delete_Button.Location = new System.Drawing.Point(104, 106);
            this.Staff_Delete_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff_Delete_Button.Name = "Staff_Delete_Button";
            this.Staff_Delete_Button.Size = new System.Drawing.Size(178, 41);
            this.Staff_Delete_Button.TabIndex = 11;
            this.Staff_Delete_Button.Text = "Delete Selected Staff";
            this.Staff_Delete_Button.UseVisualStyleBackColor = false;
            this.Staff_Delete_Button.Click += new System.EventHandler(this.Staff_Delete_Button_Click_1);
            // 
            // Staff_Display_Button
            // 
            this.Staff_Display_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Display_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Display_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Staff_Display_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Staff_Display_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Display_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Display_Button.ForeColor = System.Drawing.Color.White;
            this.Staff_Display_Button.Location = new System.Drawing.Point(104, 35);
            this.Staff_Display_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff_Display_Button.Name = "Staff_Display_Button";
            this.Staff_Display_Button.Size = new System.Drawing.Size(178, 41);
            this.Staff_Display_Button.TabIndex = 11;
            this.Staff_Display_Button.Text = "Display Details";
            this.Staff_Display_Button.UseVisualStyleBackColor = false;
            this.Staff_Display_Button.Click += new System.EventHandler(this.Staff_Display_Button_Click);
            // 
            // Prsoners_Box
            // 
            this.Prsoners_Box.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.Prsoners_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prsoners_Box.Controls.Add(this.Register_Prisoner_Button);
            this.Prsoners_Box.Controls.Add(this.Prisoners_Update_Button);
            this.Prsoners_Box.Controls.Add(this.Prisoners_Display_Button);
            this.Prsoners_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Prsoners_Box.Location = new System.Drawing.Point(691, 433);
            this.Prsoners_Box.Name = "Prsoners_Box";
            this.Prsoners_Box.Size = new System.Drawing.Size(373, 250);
            this.Prsoners_Box.TabIndex = 2;
            this.Prsoners_Box.TabStop = false;
            this.Prsoners_Box.Text = "Prisoners";
            // 
            // Staff_Update_Button
            // 
            this.Staff_Update_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Update_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Update_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Staff_Update_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Staff_Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Update_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Update_Button.ForeColor = System.Drawing.Color.White;
            this.Staff_Update_Button.Location = new System.Drawing.Point(104, 178);
            this.Staff_Update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff_Update_Button.Name = "Staff_Update_Button";
            this.Staff_Update_Button.Size = new System.Drawing.Size(178, 41);
            this.Staff_Update_Button.TabIndex = 12;
            this.Staff_Update_Button.Text = "Update Selected";
            this.Staff_Update_Button.UseVisualStyleBackColor = false;
            this.Staff_Update_Button.Click += new System.EventHandler(this.Staff_Update_Button_Click_1);
            // 
            // Staff_Insert_Button
            // 
            this.Staff_Insert_Button.BackColor = System.Drawing.Color.Transparent;
            this.Staff_Insert_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Staff_Insert_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Staff_Insert_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Staff_Insert_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Insert_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Insert_Button.ForeColor = System.Drawing.Color.White;
            this.Staff_Insert_Button.Location = new System.Drawing.Point(104, 249);
            this.Staff_Insert_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Staff_Insert_Button.Name = "Staff_Insert_Button";
            this.Staff_Insert_Button.Size = new System.Drawing.Size(178, 41);
            this.Staff_Insert_Button.TabIndex = 13;
            this.Staff_Insert_Button.Text = "Insert New Staff";
            this.Staff_Insert_Button.UseVisualStyleBackColor = false;
            this.Staff_Insert_Button.Click += new System.EventHandler(this.Staff_Insert_Button_Click_1);
            // 
            // Prisoners_Display_Button
            // 
            this.Prisoners_Display_Button.BackColor = System.Drawing.Color.Transparent;
            this.Prisoners_Display_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Prisoners_Display_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Prisoners_Display_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Prisoners_Display_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prisoners_Display_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisoners_Display_Button.ForeColor = System.Drawing.Color.White;
            this.Prisoners_Display_Button.Location = new System.Drawing.Point(104, 44);
            this.Prisoners_Display_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prisoners_Display_Button.Name = "Prisoners_Display_Button";
            this.Prisoners_Display_Button.Size = new System.Drawing.Size(178, 41);
            this.Prisoners_Display_Button.TabIndex = 12;
            this.Prisoners_Display_Button.Text = "Display Details";
            this.Prisoners_Display_Button.UseVisualStyleBackColor = false;
            this.Prisoners_Display_Button.Click += new System.EventHandler(this.Prisoners_Display_Button_Click_1);
            // 
            // Prisoners_Update_Button
            // 
            this.Prisoners_Update_Button.BackColor = System.Drawing.Color.Transparent;
            this.Prisoners_Update_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Prisoners_Update_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Prisoners_Update_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Prisoners_Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prisoners_Update_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prisoners_Update_Button.ForeColor = System.Drawing.Color.White;
            this.Prisoners_Update_Button.Location = new System.Drawing.Point(104, 114);
            this.Prisoners_Update_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prisoners_Update_Button.Name = "Prisoners_Update_Button";
            this.Prisoners_Update_Button.Size = new System.Drawing.Size(178, 41);
            this.Prisoners_Update_Button.TabIndex = 13;
            this.Prisoners_Update_Button.Text = "Update Selected";
            this.Prisoners_Update_Button.UseVisualStyleBackColor = false;
            this.Prisoners_Update_Button.Click += new System.EventHandler(this.Prisoners_Update_Button_Click);
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
            this.Register_Prisoner_Button.Location = new System.Drawing.Point(104, 185);
            this.Register_Prisoner_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Register_Prisoner_Button.Name = "Register_Prisoner_Button";
            this.Register_Prisoner_Button.Size = new System.Drawing.Size(178, 41);
            this.Register_Prisoner_Button.TabIndex = 14;
            this.Register_Prisoner_Button.Text = "Register Prisoner";
            this.Register_Prisoner_Button.UseVisualStyleBackColor = false;
            this.Register_Prisoner_Button.Click += new System.EventHandler(this.Register_Prisoner_Button_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 733);
            this.Controls.Add(this.Prsoners_Box);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.Display_Box);
            this.Name = "Display";
            this.Text = "Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Display_FormClosed);
            this.Staff.ResumeLayout(false);
            this.Prsoners_Box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Display_Box;
        private System.Windows.Forms.GroupBox Staff;
        private System.Windows.Forms.GroupBox Prsoners_Box;
        private System.Windows.Forms.Button Staff_Display_Button;
        private System.Windows.Forms.Button Staff_Delete_Button;
        private System.Windows.Forms.Button Staff_Update_Button;
        private System.Windows.Forms.Button Staff_Insert_Button;
        private System.Windows.Forms.Button Prisoners_Update_Button;
        private System.Windows.Forms.Button Prisoners_Display_Button;
        private System.Windows.Forms.Button Register_Prisoner_Button;
    }
}