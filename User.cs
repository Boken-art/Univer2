namespace Shool2
{
    class User
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True
        public string name;
        public string sur;
        public string password;
        public int userid;
        public string label;

        public User() { }

        public User(string name, string sur, string password, int userid, string label)
        {
            this.name = name;
            this.sur = sur;
            this.userid = userid;
            this.password = password;
            this.label = label;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sur
        {
            get { return sur; }
            set { sur = value; }
        }

        public string Pasword
        {
            get { return password; }
            set { password = value; }
        }
        public string Label
        {
            get { return label; }
            set { }
        }
        public int Id
        {
            get { return userid; }
            set { }
        }

    }
}
