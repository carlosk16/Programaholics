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

        public int UserID { get; set; }

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
            //BindPastApplicationsGridView();

            try
            {
                UserAccount userAccount = ClsDataLayer.FindCustomer(txtUserSearch.Text);

                if (userAccount != null)
                {
                    UserID = userAccount.ID;
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

        //private ProgramaholicsDataSet BindPastApplicationsGridView()
        //{
        //    //Database Connection
        //    string tempPath = Server.MapPath("~/AppCode/Programoholics.accdb");
        //    ClsDataLayer myDataLayer = new ClsDataLayer(tempPath);

        //    //Updates database 
        //    ProgramaholicsDataSet applicationListing = myDataLayer.GetPastApplications();

        //    //gets data and updates gridview
        //    GridView1.DataSource = applicationListing.PastApplications;

        //    //Binds data to Gridview
        //    GridView1.DataBind();
        //    Cache.Insert("CustomerDataSet", applicationListing);

        //    return applicationListing;
        //}
    }
}