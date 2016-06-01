using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TamayoWebFormCourseProjectWeb460
{
    public class Configuration
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["db"].ToString();
        }
    }
}