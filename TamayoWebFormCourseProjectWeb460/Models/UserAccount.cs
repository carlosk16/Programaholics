using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamayoWebFormCourseProjectWeb460.Models
{
    public class UserAccount
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string FavLanguage { get; set; }
        public string LeastFavLanguage { get; set; }
        public DateTime? DateOfLastProgramCompleted { get; set; }

        public List<PastApplications> PastApplications { get; set; }
    }
}