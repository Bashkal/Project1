using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEFCodeFirst
{
    internal class Category
    {
        public int Id
        {
            get;        
            set;
        }
        public string CategoryName { get; set; }
        public List<Guide> Guides
        {
            get;
            set;
        }
    }
}
