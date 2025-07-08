namespace Deneme_Sitesi.Models
{
    public class Guide
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }

        public required string Description { get; set; }

        public DateOnly DateOnly {  get; set; }
        public Guide()
        {
            
        }


    
    }
}
