using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Shool2
{
    class Settings
    {
        public string shoolConnString => ConfigurationManager.ConnectionStrings["SconnString"].ConnectionString;

        
    }
}
