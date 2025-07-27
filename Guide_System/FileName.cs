namespace Guide_System
{
    class FileName
    {
        //listing departments to choose or seek
        public static void departmantlisting(List<Department> departmentsList)
        {
            int i = 0;
            foreach (Department department in departmentsList)
            {
                Console.WriteLine("[" + i + "]" + department.ToString());
                i++;
            }
        }
        //Login page as method 
        //can be used to change user on a random page
        public static User Login(List<Department> departmentList)
        {
            try
            {
                Console.WriteLine("Enter ID");
                long id_check = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Password");
                string? password_check = Console.ReadLine();

                //only part made by Chat_GPT
                User usercheck = new User();

                foreach (Department depchoose in departmentList)
                {
                    usercheck = depchoose.GetUserlist().FirstOrDefault(u => u.getID() == id_check && u.getPassword() == password_check);
                }
                //if user exist
                if (usercheck != null)
                {
                    usercheck.setStatus(true);
                    return usercheck;
                }
                else
                {
                    //user does not exist
                    //wrong password 
                    Console.WriteLine("User does not exist or password wrong");
                    User nl = new User();
                    return nl;
                }
            }
            catch
            {
                //not availible because all fields are string
                Console.WriteLine("You have filed spaces wrong or empty character");
                User nl = new User();
                return nl;
            }
        }
        public static void Main(string[] args)
        {
            //firm departmentlist
            List<Department> departmentList = new List<Department>();
            //first admin department to save first user
            Department admindep = new Department();
            admindep.AddDepartment_info("admin");
            //first user to gain access
            User admin = new User();
            admin.addUserinfo("admin", "admin", "max", 1234, "1234");
            admindep.AddUser(admin);
            departmentList.Add(admindep);
            bool exit = false;
            //temporary user to save current user properties
            User current_user = new User();
            //app run page
            while (!exit)
            {   //check is user for wheter loged in or not 
                if (!current_user.getStatus())
                {
                    //assign user as current user
                    current_user = FileName.Login(departmentList);
                }
                else
                {
                    Console.WriteLine("[0]Add Department");
                    Console.WriteLine("[1]Add User");
                    Console.WriteLine("[2]Add Guide");
                    Console.WriteLine("[3]List Guide");
                    Console.WriteLine("[4]List Users");
                    Console.WriteLine("[5]Edit Guide");
                    Console.WriteLine("[6]Log Out");
                    Console.WriteLine("[]Exit");
                    string? selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "0":
                            Department tempdep = new Department();
                            Console.WriteLine("Enter Department Name");
                            var depname = Console.ReadLine();
                            tempdep.AddDepartment_info(depname.ToUpper());
                            departmentList.Add(tempdep);
                            Console.WriteLine();
                            break;
                        case "1":
                            departmentList[0].AddNewUser();
                            Console.WriteLine();
                            break;
                        case "2":
                            FileName.departmantlisting(departmentList);
                            Console.WriteLine("Which Department");
                            var addguide = Convert.ToInt32(Console.ReadLine());

                            if (departmentList[addguide].GetAuth().Equals(current_user.getAuth()) || current_user.getAuth().Equals("MAX"))
                            {
                                departmentList[addguide].addguide();
                            }
                            else
                            {
                                Console.WriteLine("You do not hae permission to save guide this department");
                            }
                            Console.WriteLine();
                            break;
                        case "3":
                            FileName.departmantlisting(departmentList);
                            Console.WriteLine("Which Department");
                            var listguide = Convert.ToInt32(Console.ReadLine());
                            departmentList[listguide].ListGuides();
                            Console.WriteLine();
                            break;
                        case "4":
                            FileName.departmantlisting(departmentList);
                            Console.WriteLine("Which Department");
                            var userlist = Convert.ToInt32(Console.ReadLine());
                            departmentList[userlist].ListUsers();
                            Console.WriteLine();
                            break;
                        case "5":
                            FileName.departmantlisting(departmentList);
                            Console.WriteLine("Which Department");
                            var editguide = Convert.ToInt32(Console.ReadLine());
                            departmentList[editguide].ListGuides();
                            var editguide2 = Convert.ToInt32(Console.ReadLine());
                            departmentList[editguide].GetGuideList()[editguide2].EditGuide();
                            Console.WriteLine();
                            break;
                        case "6":
                            current_user.setStatus(false);
                            break;
                        case "":
                            exit = true;
                            break;
                    }
                }

            }

        }
    }
}