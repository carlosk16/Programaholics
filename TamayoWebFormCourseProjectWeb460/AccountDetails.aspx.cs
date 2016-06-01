using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TamayoWebFormCourseProjectWeb460
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    DataSet dsSearch;

        //    //string tempPath = Server.MapPath("Accounts.mdb");
        //    string tempPath = Server.MapPath("~/App_Code/web460crsProject.accdb");
            
        //    //ClsDataLayer dataLayerObj = new ClsDataLayer(tempPath);

        //    try
        //    {
        //        dsSearch = dataLayerObj.FindCustomer(txtUserSearch.Text);

        //        if (dsSearch.UserAccount.Rows.Count > 0)
        //        {
        //            txtCity.Text = dsSearch.UserAccount[0].city;
        //            txtState.Text = dsSearch.UserAccount[0].state;
        //            txtFavLanguage.Text = dsSearch.UserAccount[0].favLanguage;
        //            txtLeastFavLanguage.Text = dsSearch.UserAccount[0].leastFavLanguage;
        //            txtDate.Text = dsSearch.UserAccount[0].dateOfLastProgramCompleted.ToString();

        //            //customerID.Text = dsFindLastName.tblCustomers[0].CustomerID.ToString();

        //            Master.UserFeedBack.Text = "Record Found";
        //        }
        //        else
        //        {
        //            Master.UserFeedBack.Text = "No records were found!";

        //        }
        //    }
        //    catch (Exception error)
        //    {
        //        string message = "Something went wrong - ";
        //        Master.UserFeedBack.Text = message + error.Message;

        //    }
        //}
    }
}