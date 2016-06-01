using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TamayoWebFormCourseProjectWeb460
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        public Label MyPrUserFeedbackoperty
        {
            get { return UserFeedback; }
            set { UserFeedback = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}