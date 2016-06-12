using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamayoWebFormCourseProjectWeb460.AppCode;
using TamayoWebFormCourseProjectWeb460.Models;

namespace TamayoWebFormCourseProjectWeb460
{
    public partial class pgLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.MyPrUserFeedbackoperty.Text = "Please enter Username and Password.";
            // Check if the user is already loged in or not
            if ((Session["Check"] != null) && (Convert.ToBoolean(Session["Check"]) == true))
            {
                // If User is Authenticated then moved to a main page
                if (User.Identity.IsAuthenticated)
                    Response.Redirect("AccountDetails.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Checks user login
            UserAccount userAccount = ClsBusinessLayer.CheckUserCredentials(Session, txtUsername.Text, txtPassword.Text);

            //Decision tree for user login
            if (userAccount != null)
            {
                //Takes user to this page
                Session["Username"] = userAccount.UserName;
                Response.Redirect("~/AccountDetails.aspx");
            }
            else if (Convert.ToBoolean(Session["LockedSession"]))
            {
                Master.MyPrUserFeedbackoperty.Text = "Account is disabled. Contact System Administrator";

                //Hide login button
                btnLogin.Visible = false;
            }
            else
            {
                //Displays failed attempts
                Master.MyPrUserFeedbackoperty.Text = "The User ID and/or Password supplied is incorrect. Please try again!";
            }
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
           int userAccountResult = ClsDataLayer.CreateUserAccount(txtUsername.Text, txtPassword.Text);

            if (userAccountResult == 1)
            {
                //Takes user to this page
                Response.Redirect("~/AccountDetails.aspx");
            }
            else
            {
                //Displays failed creation of a new user account
                Master.MyPrUserFeedbackoperty.Text = "User Account was not created. Please try a different username or password.";
            }
        }
    }
}