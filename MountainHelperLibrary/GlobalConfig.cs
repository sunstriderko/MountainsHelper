using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace MountainHelperLibrary
{
    public static class GlobalConfig
    {
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            //This is gonna look for which of connection string from app.config it is gonna use and return that value
            //Name database v app.config nemusi byt rovnaky ako je nazov database, to si urcime podla seba, connection string urcuje cestu
        }
    }
}
