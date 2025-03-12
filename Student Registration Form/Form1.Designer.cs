using System.Drawing;

namespace Student_Registration_Form
{
    partial class Form1
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
            this.Months = new System.Windows.Forms.ComboBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Register = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.program = new System.Windows.Forms.Label();
            this.Programs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Months
            // 
            this.Months.FormattingEnabled = true;
            this.Months.Location = new System.Drawing.Point(85, 304);
            this.Months.MaximumSize = new System.Drawing.Size(100, 0);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(100, 24);
            this.Months.TabIndex = 13;
            this.Months.Text = "-Month-";
            this.Months.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(4, 84);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(242, 22);
            this.LastName.TabIndex = 0;
            this.LastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(4, 137);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(242, 22);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(4, 190);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(242, 22);
            this.MiddleName.TabIndex = 2;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Male.Location = new System.Drawing.Point(110, 234);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(57, 20);
            this.Male.TabIndex = 3;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Female.Location = new System.Drawing.Point(173, 234);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(73, 20);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last name*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "First name*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = " Middle name*";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(4, 229);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(96, 25);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender: ";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of birth*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Location = new System.Drawing.Point(4, 304);
            this.Day.MaximumSize = new System.Drawing.Size(100, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(75, 24);
            this.Day.TabIndex = 11;
            this.Day.Text = "-Day-";
            this.Day.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Location = new System.Drawing.Point(191, 304);
            this.Year.MaximumSize = new System.Drawing.Size(100, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(91, 24);
            this.Year.TabIndex = 12;
            this.Year.Text = "-Year-";
            this.Year.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(4, 407);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(212, 38);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register Student";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(-3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(290, 37);
            this.Title.TabIndex = 14;
            this.Title.Text = "Student Registration ";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // program
            // 
            this.program.AutoSize = true;
            this.program.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program.Location = new System.Drawing.Point(2, 343);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(165, 23);
            this.program.TabIndex = 15;
            this.program.Text = "Program to apply*";
            // 
            // Programs
            // 
            this.Programs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programs.FormattingEnabled = true;
            this.Programs.Location = new System.Drawing.Point(3, 372);
            this.Programs.Name = "Programs";
            this.Programs.Size = new System.Drawing.Size(377, 25);
            this.Programs.TabIndex = 16;
            this.Programs.Text = "-Select program-";
            this.Programs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(838, 515);
            this.Controls.Add(this.Programs);
            this.Controls.Add(this.program);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Name = "Form1";
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Months;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label program;
        private System.Windows.Forms.ComboBox Programs;
    }
}

