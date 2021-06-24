using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class User
    {
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True
        public string name;
        public string sur;
        public string reg_year;
        public string pasword;
        public int userid;
        public string label;

        public User(){}

        public User(string name, string sur, string pasword, int userid, string label)
        {
            this.name = name;
            this.sur = sur;
            this.userid = userid;
            this.pasword = pasword;
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
            get { return pasword; }
            set { pasword = value; }
        }
        public string RegYear
        {
            get { return reg_year; }
            set { }
        }
        public string GetLabel
        {
            get { return label; }
            set { }
        }

    }
}
