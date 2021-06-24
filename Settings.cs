using System.Configuration;

namespace Shool2
{
    class Settings
    {
        public string shoolConnString => ConfigurationManager.ConnectionStrings["SconnString"].ConnectionString;


    }
}
