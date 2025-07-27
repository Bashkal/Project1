using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

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
        public  string Name
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Departman seçimi zorunludur")]
        public   Guid DepartmentId
        {
            get;
            set;
        }
        public Department Department { get; set; }
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
        public  string  Path
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

