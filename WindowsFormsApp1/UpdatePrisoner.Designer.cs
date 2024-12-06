namespace WindowsFormsApp1
{
    partial class UpdatePrisoner
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
            this.Prisoner_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LawyerID_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateTrial_Button = new System.Windows.Forms.Button();
            this.UpdateCrimeHistory_GroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateCrimeHistory_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.UpdateLawyer_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.UpdateCrimeHistory_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prisoner_ID
            // 
            this.Prisoner_ID.Location = new System.Drawing.Point(210, 58);
            this.Prisoner_ID.Name = "Prisoner_ID";
            this.Prisoner_ID.Size = new System.Drawing.Size(197, 22);
            this.Prisoner_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prisoner ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.UpdateTrial_Button);
            this.groupBox1.Controls.Add(this.LawyerID_Textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(56, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(369, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update ";
            this.groupBox1.Visible = false;
            // 
            // LawyerID_Textbox
            // 
            this.LawyerID_Textbox.Location = new System.Drawing.Point(154, 23);
            this.LawyerID_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.LawyerID_Textbox.Name = "LawyerID_Textbox";
            this.LawyerID_Textbox.Size = new System.Drawing.Size(197, 26);
            this.LawyerID_Textbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lawyer ID";
            // 
            // UpdateTrial_Button
            // 
            this.UpdateTrial_Button.BackColor = System.Drawing.Color.Transparent;
            this.UpdateTrial_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateTrial_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.UpdateTrial_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UpdateTrial_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTrial_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTrial_Button.ForeColor = System.Drawing.Color.White;
            this.UpdateTrial_Button.Location = new System.Drawing.Point(229, 100);
            this.UpdateTrial_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateTrial_Button.Name = "UpdateTrial_Button";
            this.UpdateTrial_Button.Size = new System.Drawing.Size(122, 30);
            this.UpdateTrial_Button.TabIndex = 10;
            this.UpdateTrial_Button.Text = "Update Trial";
            this.UpdateTrial_Button.UseVisualStyleBackColor = false;
            this.UpdateTrial_Button.Click += new System.EventHandler(this.UpdateTrial_Button_Click);
            // 
            // UpdateCrimeHistory_GroupBox
            // 
            this.UpdateCrimeHistory_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.UpdateCrimeHistory_GroupBox.Controls.Add(this.UpdateCrimeHistory_Button);
            this.UpdateCrimeHistory_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCrimeHistory_GroupBox.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCrimeHistory_GroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCrimeHistory_GroupBox.Location = new System.Drawing.Point(56, 344);
            this.UpdateCrimeHistory_GroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCrimeHistory_GroupBox.Name = "UpdateCrimeHistory_GroupBox";
            this.UpdateCrimeHistory_GroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UpdateCrimeHistory_GroupBox.Size = new System.Drawing.Size(369, 132);
            this.UpdateCrimeHistory_GroupBox.TabIndex = 8;
            this.UpdateCrimeHistory_GroupBox.TabStop = false;
            this.UpdateCrimeHistory_GroupBox.Text = "Update Crime History";
            this.UpdateCrimeHistory_GroupBox.Visible = false;
            // 
            // UpdateCrimeHistory_Button
            // 
            this.UpdateCrimeHistory_Button.BackColor = System.Drawing.Color.Transparent;
            this.UpdateCrimeHistory_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateCrimeHistory_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.UpdateCrimeHistory_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UpdateCrimeHistory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCrimeHistory_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCrimeHistory_Button.ForeColor = System.Drawing.Color.White;
            this.UpdateCrimeHistory_Button.Location = new System.Drawing.Point(87, 55);
            this.UpdateCrimeHistory_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateCrimeHistory_Button.Name = "UpdateCrimeHistory_Button";
            this.UpdateCrimeHistory_Button.Size = new System.Drawing.Size(197, 30);
            this.UpdateCrimeHistory_Button.TabIndex = 10;
            this.UpdateCrimeHistory_Button.Text = "Update Crime History";
            this.UpdateCrimeHistory_Button.UseVisualStyleBackColor = false;
            this.UpdateCrimeHistory_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Close_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.Close_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.Color.White;
            this.Close_Button.Location = new System.Drawing.Point(562, 446);
            this.Close_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(122, 30);
            this.Close_Button.TabIndex = 11;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click_1);
            // 
            // UpdateLawyer_Button
            // 
            this.UpdateLawyer_Button.BackColor = System.Drawing.Color.Transparent;
            this.UpdateLawyer_Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UpdateLawyer_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan;
            this.UpdateLawyer_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UpdateLawyer_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateLawyer_Button.Font = new System.Drawing.Font("CMU Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateLawyer_Button.ForeColor = System.Drawing.Color.White;
            this.UpdateLawyer_Button.Location = new System.Drawing.Point(506, 50);
            this.UpdateLawyer_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateLawyer_Button.Name = "UpdateLawyer_Button";
            this.UpdateLawyer_Button.Size = new System.Drawing.Size(178, 30);
            this.UpdateLawyer_Button.TabIndex = 11;
            this.UpdateLawyer_Button.Text = "Update Lawyer";
            this.UpdateLawyer_Button.UseVisualStyleBackColor = false;
            this.UpdateLawyer_Button.Click += new System.EventHandler(this.UpdateLawyer_Button_Click);
            // 
            // UpdatePrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 624);
            this.Controls.Add(this.UpdateLawyer_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.UpdateCrimeHistory_GroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prisoner_ID);
            this.Name = "UpdatePrisoner";
            this.Text = "UpdatePrisoner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdatePrisoner_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UpdateCrimeHistory_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Prisoner_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LawyerID_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateTrial_Button;
        private System.Windows.Forms.GroupBox UpdateCrimeHistory_GroupBox;
        private System.Windows.Forms.Button UpdateCrimeHistory_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button UpdateLawyer_Button;
    }
}