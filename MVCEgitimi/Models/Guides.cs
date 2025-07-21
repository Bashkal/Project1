namespace MVCEgitimi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guides
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTimeOffset DateofChange { get; set; }

        public int CategoryId { get; set; }

        public virtual Categories Categories { get; set; }
    
    public Guides() 
            {
                this.CategoryId = 1;
                this.DateofChange = DateTimeOffset.Now;
            }
        }     
    } 
