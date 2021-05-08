using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class Work
    {
        public string workname;
        public string studentid;
        public string predmetid;
        //public string raiting;
      
        public string titul;

        public Work(string workname, string studentid,string predmetid/*,string raiting*/, string titul )
        {
            this.workname = workname;
            this.studentid = studentid;
            this.predmetid = predmetid;
            //this.raiting = raiting;
            this.titul = titul;
            
        }
       
    }
}
