using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEgitimi.Models
{
    public class User
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
    }
}