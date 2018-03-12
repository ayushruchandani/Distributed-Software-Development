using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string firstName, lastName;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblAgeError.Text = "";
            lblAnswer.Text = "";
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";

            int age;
            myServiceRef.Service1Client proxy = new myServiceRef.Service1Client();
            if (txtAge.Text == "" || txtFirstName.Text == "" || txtFirstName.Text.Length < 2 || txtLastName.Text == "" || txtLastName.Text.Length < 2)
            {
                if (txtFirstName.Text == "")
                {
                    lblFirstNameError.Text = "You cannot leave First Name field empty";
                }
                else if (txtFirstName.Text.Length < 2)
                {
                    lblFirstNameError.Text = "First name should contain more than 2 characters";
                }
                if (txtLastName.Text == "")
                {
                    lblLastNameError.Text = "You cannot leave Last Name field empty";
                }
                else if (txtLastName.Text.Length < 2)
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
                    lblAgeError.Text = "Age should be an integer";
                }
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            lblAgeError.Text = "";
            lblFirstNameError.Text = "";
            lblLastNameError.Text = "";
            lblAnswer.Text = "";
        }
    }
}