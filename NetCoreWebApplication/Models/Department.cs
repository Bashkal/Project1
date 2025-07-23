namespace NetCoreWebApplication.Models
{
    public class Department
    {
        public Guid Id
        {
            get; set;
        }
        public required string Name
        {
            get; set;
        }
        public string? AuthorizedUser
        {
            get; set;
        }
        public int EmployeeCount
        {
            get; set;
        }
        public int GuideCount
        {
            get; set;
        }

    }
    }

