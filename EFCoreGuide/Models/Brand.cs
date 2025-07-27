using System.ComponentModel.DataAnnotations;

namespace EFCoreGuide.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Guide>? Guides { get; set; }
    }
}
