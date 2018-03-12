using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginIDPasswordGeneratoClient1
{
    public partial class Form1 : Form
    {
        string firstName, lastName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            lblAgeError.Text = "";
            lblAnswer.Text = "";
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            if (txtAge.Text == "" || txtFirstName.Text == "" || txtFirstName.Text.Length < 2 || txtLastName.Text == "" || txtLastName.Text.Length < 2)
            {
                if (txtFirstName.Text == "")
                {
                    lblFirstNameError.Text = "You cannot leave First Name field empty";
                }
                else if(txtFirstName.Text.Length < 2)
                {
                    lblFirstNameError.Text = "First name should contain more than 2 characters";
                }
                if (txtLastName.Text == "")
                {
                    lblLastNameError.Text = "You cannot leave Last Name field empty";
                }
                else if(txtLastName.Text.Length < 2)
                {
                    lblLastNameError.Text = "Last name should contain more than 2 characters";
                }
                if (txtAge.Text == "")
                {
                    lblAgeError.Text = "You cannot leave age field empty";
                }
            }
            else
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                if (int.TryParse(txtAge.Text, out age) && age > 0)
                {
                    lblAgeError.Text = "";
                    lblFirstNameError.Text = "";
                    lblLastNameError.Text = "";
                    lblAnswer.Text = "Your LoginID is " + proxy.loginId(age) + " and your password is " + proxy.password(firstName.ToLower(), lastName.ToLower(), age);
                }
                else
                {
                    lblAgeError.Text = "Age should be a positive integer";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            lblAgeError.Text = "";
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";
            lblAnswer.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
