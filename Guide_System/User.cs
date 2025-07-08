namespace Guide_System
{
    class User
    {
        private string name;
        private string lname;
        private string department;
        private long user_id;
        private string password;
        private string authorization;
        private bool login_status = false;
        public void addUserinfo(string name, string lname, string department, long user_id, string password)
        {
            this.name = name;
            this.lname = lname;
            this.department = department.ToUpper();
            this.user_id = user_id;
            this.password = password;
            authorization = department.ToUpper();
        }
        public void addUserinfo(string name, string lname, long user_id, string password)
        {
            this.name = name;
            this.lname = lname;
            this.user_id = user_id;
            this.password = password;
        }
        public override string ToString()
        {
            return name + " " + lname + " " + department;
        }
        public long getID()
        {
            return user_id;
        }
        public string getPassword()
        {
            return password;
        }
        public void setStatus(bool stat)
        {
            login_status = stat;
        }
        public bool getStatus()
        {
            return login_status;
        }
        public void setdepartment(User user, Department dep)
        {
            user.department = dep.getName().ToUpper();
            user.authorization = dep.getName().ToUpper();
        }
        public string getAuth()
        {
            return authorization;
        }
    }
}
