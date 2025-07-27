using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCoreGuide.Models
{
    public class Department
    {
        public int Id{ get; set; }
        [StringLength(50)]
        public required string Name { get; set; }
        [Column("Description", TypeName = "nvarchar(500)")]
        [MaxLength(500)]
        public string? Description { get; set; }
        public ICollection<Guide>? Guides { get; set; }
    }
}
