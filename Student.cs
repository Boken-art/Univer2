using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{

    class Student : User
    {
        public string studentid;
        public string password;

        public Student(string studentid,string password)
        {
            this.studentid = studentid;
            this.password = password;

        }
        public string Pass
        {
            get { return password; }
            set { password = value; }
        }
       

    }
}
