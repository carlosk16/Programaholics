﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TamayoWebFormCourseProjectWeb460.AppCode;

namespace TamayoWebFormCourseProjectWeb460
{
    public partial class AccountDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ProgramaholicsDataSet dsSearch;

            //string tempPath = Server.MapPath("Accounts.mdb");
            string tempPath = Server.MapPath("~/App_Code/web460crsProject.accdb");

            ClsDataLayer dataLayerObj = new ClsDataLayer(tempPath);

            try
            {
                dsSearch = dataLayerObj.FindCustomer(txtUserSearch.Text);

                if (dsSearch.UserAccount.Rows.Count > 0)
                {
                    txtCity.Text = dsSearch.UserAccount[0].City;
                    txtState.Text = dsSearch.UserAccount[0].State;
                    txtFavLanguage.Text = dsSearch.UserAccount[0].FavLanguage;
                    txtLeastFavLanguage.Text = dsSearch.UserAccount[0].LeastFavLanguage;
                    txtDate.Text = dsSearch.UserAccount[0].DateOfLastProgramCompleted.ToString();

                    //customerID.Text = dsFindLastName.tblCustomers[0].CustomerID.ToString();

                    Master.MyPrUserFeedbackoperty = "Record Found";
                }
                else
                {
                    Master.MyPrUserFeedbackoperty = "No records were found!";

                }
            }
            catch (Exception error)
            {
                string message = "Something went wrong - ";
                Master.MyPrUserFeedbackoperty = message + error.Message;
            }
        }
    }
}