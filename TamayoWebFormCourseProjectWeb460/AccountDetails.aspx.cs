using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamayoWebFormCourseProjectWeb460.AppCode;
using TamayoWebFormCourseProjectWeb460.Models;

namespace TamayoWebFormCourseProjectWeb460
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

     
        public string UserId
        {
            get { return hdField1.Value; }
        }


        public string City //Retreives value from City Text box
        {
            get
            {
                return txtCity.Text;
            }
        }

        public string State //Retreives value from State Text box
        {
            get
            {
                return txtState.Text;
            }
        }

        public string FavoriteProgrammingLanguage
        {
            get
            {
                return txtFavLanguage.Text;
            }
        }

        public string LeastFavoriteProgrammingLanguage
        {
            get
            {
                return txtLeastFavLanguage.Text;
            }
        }

        public string DateofLastProgramCompleted
        {
            get
            {
                return txtDate.Text;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            

            try
            {
                UserAccount userAccount = ClsDataLayer.FindCustomer(txtUserSearch.Text);
                BindPastApplicationsGridView(userAccount.ID);

                if (userAccount != null)
                {
                    hdField1.Value = userAccount.ID.ToString();
                    txtCity.Text = userAccount.City;
                    txtState.Text = userAccount.State;
                    txtFavLanguage.Text = userAccount.FavLanguage;
                    txtLeastFavLanguage.Text = userAccount.LeastFavLanguage;
                    txtDate.Text = userAccount.DateOfLastProgramCompleted.Value.ToString();

                    //customerID.Text = dsFindLastName.tblCustomers[0].CustomerID.ToString();

                    Master.MyPrUserFeedbackoperty.Text = "Record Found";
                }
                else
                {
                    Master.MyPrUserFeedbackoperty.Text = "No records were found!";

                }
            }
            catch (Exception error)
            {
                string message = "Something went wrong - ";
                Master.MyPrUserFeedbackoperty.Text = message + error.Message;
            }
        }

        private void BindPastApplicationsGridView(int userAccountId)
        {
            List<PastApplication> pastApplication = ClsDataLayer.GetPastApplications(userAccountId);

            //gets data and updates gridview
            GridView1.DataSource = pastApplication;

            //Binds data to Gridview
            GridView1.DataBind();
            Cache.Insert("CustomerDataSet", pastApplication);
        }
    }
}