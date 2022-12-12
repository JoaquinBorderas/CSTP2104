using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace _2104_Sep_2022
{
    public class AppConfigReader
    {
        public void ReadConnectionStrings() 
        {
            foreach (ConnectionStringSettings css in ConfigurationManager.ConnectionStrings) 
            { 
                Console.WriteLine(css.Name);
                Console.WriteLine(css.ProviderName);
                Console.WriteLine(css.ConnectionString);

            }
        }
        public string GetConnectionString(string name) 
        {
            var connectionStringSetting = ConfigurationManager.ConnectionStrings[name];
            return connectionStringSetting.ConnectionString;
        }
    }
}
