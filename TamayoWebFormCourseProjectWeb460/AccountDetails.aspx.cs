using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
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

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int result = ClsDataLayer.DeleteAccount(Convert.ToInt32(hdField1.Value));

            if (result != 1)
            {
                
                string message = "Error Deleting customer account, please check form data.";
                Master.MyPrUserFeedbackoperty.Text = message;
            }
            else
            {
                ClearInputs(Page.Controls);
                Master.MyPrUserFeedbackoperty.Text = "Customer Account was Deleted Successfully.";
            }
        }

        //Export data from past application table
        protected void btnExportStats (object sender, EventArgs e)
        {
           
            List<PastApplication> result = ClsDataLayer.GetPastApplications(Convert.ToInt32(hdField1.Value));
            
            string export = Serialize.SerializeObject<List<PastApplication>>(result);

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = "text/plain";
            response.AddHeader("Content-Disposition", "attachment; filename=" + "Past Applications.txt" + ";");
            Response.Write(export);
            response.Flush();
            response.End();
        }

        private void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;

                else
                    ClearInputs(ctrl.Controls);
            }
        }

    }
}