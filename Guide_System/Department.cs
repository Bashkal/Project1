namespace Guide_System
{
    internal class Department
    {
        private string name;
        private string dep_authorization;
        private List<User> userlist = new List<User>();
        private List<Guide> guidelist = new List<Guide>();
        public void AddDepartment_info(string name)
        {
            this.name = name.ToUpper();
            dep_authorization = name.ToUpper();
        }
        public void AddNewUser()
        {
            var tempuser = new User();
            Console.WriteLine("Please Enter User Name");
            var name = Console.ReadLine();
            Console.WriteLine("Please Enter User Surname");
            var lname = Console.ReadLine();
            Console.WriteLine("Please Enter User Id");
            var user_id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please Enter User Password");
            var password = Console.ReadLine();
            tempuser.addUserinfo(name, lname, user_id, password);
            userlist.Add(tempuser);
        }
        public void AddUser(User adduserdirect)
        {
            userlist.Add(adduserdirect);
        }
        public void addguide()
        {
            Guide tempguide = new Guide();
            Console.WriteLine("Please Enter Guide Title");
            var title = Console.ReadLine();
            Console.WriteLine("Please Enter Guide size");
            var size = Console.ReadLine();
            Console.WriteLine("Please Enter Guide path");
            var path = Console.ReadLine();
            tempguide.AddGuide(title, size, path);
            guidelist.Add(tempguide);
        }
        public void ListUsers()
        {
            foreach (User user in userlist)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public void ListGuides()
        {
            int i = 0;
            foreach (Guide guide in guidelist)
            {
                Console.WriteLine("[" + i + "]" + guide.ToString());
            }
        }
        public override string ToString()
        {
            return name;
        }
        public string GetAuth()
        {
            return dep_authorization;
        }
        public List<User> GetUserlist()
        {
            return userlist;
        }
        public List<Guide> GetGuideList()
        {
            return guidelist;
        }
        public string GetName()
        {
            return name;
        }
    }
}