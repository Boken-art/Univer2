using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{

    class Teacher : User
    {
        public string predmetid;

        public Teacher (string predmetid)
        {
            this.predmetid = predmetid;
            this.label = "Teacher";
        }
           
    }
}
