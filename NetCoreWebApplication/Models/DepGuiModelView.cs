using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebApplication.Models
{
    public class DepGuiModelView
    {
      
        public required Guide Guides { get; set;
        }
        public required List<Department> Departments { get; set;
        }


        
    }
}
