using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class users
    {
        public users()
        {
            Fname = "Ali";
            Lname = "Fani";
            gensiat = false;
            status = false;
            email = "alifani1377@gmail.com";
            tel = 123455;
        }
        public string aboutme { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool gensiat { get; set; }
        public bool status { get; set; }
        public string email { get; set; }
        public int tel { get; set; }
        public bool ischecked { get; set; }
    }

}