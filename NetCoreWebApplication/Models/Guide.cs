using Newtonsoft.Json;

namespace NetCoreWebApplication.Models
{
    public class Guide
    {
        public Guid Id
        {
            get;
            set;
        }

        // [JsonProperty("name")] if database has different named column we can use this attribute to map it
        public required string Name
        {
            get;
            set;
        }
        public  required string DepartmentId
        {
            get;
            set;
        }
        public string? Description
        {
            get;
            set;
        }
        public DateTime CreatedDate
        {
            get;
            set;
        }
        public DateTime UpdatedDate
        {
            get;
            set;
        }
        public string? CreatedBy
        {
            get;
            set;
        }
        public required string  Path
        {
            get;
            set;
        }

        public Guide()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
    
       
    }

