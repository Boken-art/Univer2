using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shool2
{
    class Predmet
    {
        public string predmetid;
        public string predmetName;
        public string kurs;
        public Predmet ()
        {

        }
        public Predmet(string predmetid,string predmetName,string kurs)
        {
            this.predmetid = predmetid;
            this.predmetName = predmetName;
            this.kurs = kurs;
        }
    }
}
