using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TamayoWebFormCourseProjectWeb460.Models
{
    public class PastApplication
    {
        public int ID { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string LanguageUsed { get; set; }
        public bool ApplicationComplated { get; set; }
        public int UserAccountId { get; set; }
    }
}