using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // the using directives are also referred to as binaries
using System.IO;

namespace lab_22_http_get_async
{
    class Program
    {
        static void Main(string[] args)
        {
            // SYNC READ OF HTTP DATA
            Uri bbc01 = new Uri("http://www.bbc.co.uk"); // HTTP
            Uri bbc02 = new Uri("https://www.bbc.co.uk"); // ENCRYPTED HTTPS

            Console.WriteLine(bbc01.Host); // HOST GIVES AN IP 
            Console.WriteLine(bbc01.Port);

            Console.WriteLine(bbc02.Host);
            Console.WriteLine(bbc02.Port);

           // SIMPLEST WAY TO READ DATA IS WITH 'WEBCLIENT'
            var bbcWebClient = new WebClient {Proxy = null};
            bbcWebClient.DownloadFile(bbc01, "local-copy-of-bbc01.html");
            Console.WriteLine(File.ReadAllText("local-copy-of-bbc01.html"));
        }
    }
}
