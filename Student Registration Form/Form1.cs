using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Register.BackColor = Color.Crimson;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font(Register.Font.FontFamily, 12);
            Register.ForeColor = Color.White;
            for (int i = 1; i <= 31; i++) // for days
                Day.Items.Add(i);

            

            for (int i = 1900; i <= DateTime.Now.Year; i++)
                Year.Items.Add(i); // for years
            string[] months = { "January", "February", "March", "April", "May", "June",
                                "July", "August", "September", "October", "November", "December" };

            
            foreach (string month in months)
            {
                Months.Items.Add(month);
            }

           
            ArrayList programs = new ArrayList
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering"
            };

           
            foreach (string program in programs)
            {
                Programs.Items.Add(program);
            }



        }
    
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register.BackColor = Color.Crimson;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font(Register.Font.FontFamily, 12);
            Register.ForeColor = Color.White;
            string lastName = LastName.Text;
            string firstName = FirstName.Text;
            string middleName = MiddleName.Text;

            string gender = Male.Checked ? "Male" : Female.Checked ? "Female" : "Not specified";

            string day = Day.SelectedItem?.ToString() ?? "0";
            string month = Months.SelectedItem?.ToString() ?? "0";
            string year = Year.SelectedItem?.ToString() ?? "0000";

            string fullName = $"{firstName} {middleName} {lastName}".Trim();
            string dob = $"{day}/{month}/{year}";

            MessageBox.Show($"Student name: {fullName}\nGender: {gender}\nDate of birth: {dob}");



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string gender = "";

            if (Male.Checked)
            {
                gender = "Male";
                Male.ForeColor = Color.Black;


            }
            else if (Female.Checked)
            {
                gender = "Female";
                Female.ForeColor = Color.Black;
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            if (Female.Checked)
            {
                Gender.ForeColor = Color.Black;
            }
        }

        private void Gender_Click(object sender, EventArgs e)
        {
            if (Male.Checked)
            {
                Gender.ForeColor = Color.Black;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
