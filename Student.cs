using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{

    class Student : User
    {
        
        public string kurs;
        private string titul;
        public int score;
        
        public Student(string kurs)
        {
            this.label = "Student";
            this.kurs = kurs;
            this.titul = "Bc";
            this.score = 0;

        }
       

    }
}
