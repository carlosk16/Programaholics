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
    public partial class Confirmation : System.Web.UI.Page
    {
        UserAccount ua;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (PreviousPage.IsCrossPagePostBack)//These lines of code retrieves the text fields entered in the Check out page If there is a cross page post back.
                {
                    ua.ID = PreviousPage.UserID;
                    citylbl.Text = PreviousPage.City;
                    statelbl.Text = PreviousPage.State;
                    favLanguagelbl.Text = PreviousPage.FavoriteProgrammingLanguage;
                    leastFavLanuagelbl.Text = PreviousPage.LeastFavoriteProgrammingLanguage;
                    datelbl.Text = PreviousPage.DateofLastProgramCompleted;
                    this.Master.MyPrUserFeedbackoperty.Text = " Please confirm your information.";
                }
            }
            catch (Exception error)
            {
                this.Master.MyPrUserFeedbackoperty.Visible = true;
                this.Master.MyPrUserFeedbackoperty.Text = "Sorry, there was an error processing your request. " + error.Message;
            }
        }

        protected void btnUpdateAndConfirm_Click(object sender, EventArgs e)
        {
            int result = ClsDataLayer.UpdateAccount(PreviousPage.UserID, citylbl.Text, statelbl.Text, leastFavLanuagelbl.Text, leastFavLanuagelbl.Text, datelbl.Text);

            if (result != 1)
            {
                string message = "Error updating customer, please check form data.";
                Master.MyPrUserFeedbackoperty.Text = message;
            }
            else
            {
                //ClearInputs(Page.Controls);
                Master.MyPrUserFeedbackoperty.Text = "Customer Updated Successfully.";
            }
        }
    }
}