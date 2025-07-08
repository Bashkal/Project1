namespace Guide_System
{
    class Guide
    {
        private string? title;
        private string? size;
        private string? upload_date;
        private string? path;
        public void addGuide(string? title, string? size, string? path)
        {
            this.title = title + Convert.ToString(DateTime.Today);
            this.size = size;
            this.path = path;
            upload_date = Convert.ToString(DateTimeOffset.Now);
        }
        public override string ToString()
        {
            return title + " " + size + " " + path + " " + upload_date;
        }
        public void editGuide()
        {
            ToString();
            Console.WriteLine("Title:");
            string? temptitle = Console.ReadLine();
            Console.WriteLine("Path:");
            string? temppath = Console.ReadLine();
            if (temptitle != null)
            {
                title = temptitle;
                upload_date = upload_date + " " + Convert.ToString(DateTimeOffset.Now);
            }
            if (temppath != null)
            {
                path = temppath;
                upload_date = upload_date + " " + Convert.ToString(DateTimeOffset.Now);
            }
        }
    }
}
