using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Swapi.Client.Configurations
{
    internal sealed class AppConfig
    {
        private static string _starWarsAPIUrl;
        private static string _filePath;

        public string starWarsAPIUrl { get { return _starWarsAPIUrl; } }
        public string filePath { get { return _filePath; } }

        public static void initialize()
        {
            _starWarsAPIUrl = ConfigurationManager.AppSettings["StarWarsAPIUrl"].ToString();
            _filePath = ConfigurationManager.AppSettings["FilePath"].ToString();
        }
    }
}