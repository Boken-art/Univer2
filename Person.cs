using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class Person
    {
        public Person()
        {
        }

        public Person(string password, string name, string surename)
        {
            Password = password;
            Name = name;
            
        }

        public string Password {  get; set; }
        public string Name { get; set; }
    }

}
