using System.ComponentModel.DataAnnotations;

namespace EFCoreGuide.Models
{
    //[Table("Guides")]Şeklinde tablo adını değiştirebilirsiniz.
    public class Guide
    {//[Key] attribute is not necessary if the property name is "Id" or "ClassNameId" (where ClassName is the name of the class).BUt  you can use it to explicitly define the primary key.
        public int Id { get; set; }
        [StringLength(100)]
        public required string Title { get; set; }
        public required string Description { get; set; }
        //[NotMapped] //This property will not be mapped to the database.
        public string? Path { get; set; }
        public int DepartmentId { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public Department? Department { get; set; }
    }
}
