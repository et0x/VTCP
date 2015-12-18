using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace VTCP
{
    class VirusTotalHandler
    {

        public string APIKey { get; set; }
        public int DetectionThreshold = 10;
        WebClient client = new WebClient();

        public VirusTotalHandler()
        {
            
        }

        public string CheckHash(string hash)
        {
            string uri = "http://www.virustotal.com/vtapi/v2/file/report";
            byte[] response =
                client.UploadValues(uri, new System.Collections.Specialized.NameValueCollection()
                {
                    { "apikey", APIKey },
                    { "resource", hash }
                }
                );

            return System.Text.Encoding.UTF8.GetString(response);
        }

    }
}
