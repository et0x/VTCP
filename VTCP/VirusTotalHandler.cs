using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace VTCP
{
    internal class VirusTotalHandler
    {
        private readonly WebClient _client = new WebClient();
        public int DetectionThreshold = 10;

        public string ApiKey { get; set; }

        public string CheckHash(string hash)
        {
            var uri = "http://www.virustotal.com/vtapi/v2/file/report";
            var response =
                _client.UploadValues(uri, new NameValueCollection
                {
                    {"apikey", ApiKey},
                    {"resource", hash}
                }
                    );

            return Encoding.UTF8.GetString(response);
        }
    }
}