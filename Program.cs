using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace AccessRESTAPI_JIRA
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseURL = ConfigurationManager.AppSettings["JIRABaseURL"];

            //API to Invoke CreateMetadata
            string CreateMetadataAPI = "issue/createmeta";
        }
    }
}
