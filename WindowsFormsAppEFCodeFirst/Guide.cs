using System;

namespace WindowsFormsAppEFCodeFirst
{
    internal class Guide
    {
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public DateTimeOffset DateofChange
        {
            get; set;
        }
        public Category Category
        {
            get;
            set;
        }
        public  int CategoryId
        {
            get;
            set;
        }
    }
}
