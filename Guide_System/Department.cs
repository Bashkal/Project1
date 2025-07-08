namespace Guide_System
{
    internal class Department
    {
        private string name;
        private string dep_authorization;
        private List<User> userlist = new List<User>();
        private List<Guide> guidelist = new List<Guide>();
        public void addDepartment_info(string name)
        {
            this.name = name.ToUpper();
            dep_authorization = name.ToUpper();
        }
        public void addNewUser()
        {
            User tempuser = new User();
            Console.WriteLine("Please Enter User Name");
            string? name = Console.ReadLine();
            Console.WriteLine("Please Enter User Surname");
            string? lname = Console.ReadLine();
            Console.WriteLine("Please Enter User Id");
            long user_id = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please Enter User Password");
            string? password = Console.ReadLine();
            tempuser.addUserinfo(name, lname, user_id, password);
            userlist.Add(tempuser);
        }
        public void addUser(User adduserdirect)
        {
            userlist.Add(adduserdirect);
        }
        public void addguide()
        {
            Guide tempguide = new Guide();
            Console.WriteLine("Please Enter Guide Title");
            string? title = Console.ReadLine();
            Console.WriteLine("Please Enter Guide size");
            string? size = Console.ReadLine();
            Console.WriteLine("Please Enter Guide path");
            string? path = Console.ReadLine();
            tempguide.addGuide(title, size, path);
            guidelist.Add(tempguide);
        }
        public void listUsers()
        {
            foreach (User user in userlist)
            {
                Console.WriteLine(user.ToString());
            }
        }
        public void listGuides()
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
        public string getAuth()
        {
            return dep_authorization;
        }
        public List<User> getUserlist()
        {
            return userlist;
        }
        public List<Guide> getGuideList()
        {
            return guidelist;
        }
        public string getName()
        {
            return name;
        }
    }
}