using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitTextFileDownloader
{
    public class DownloadHelper
    {
        public void Download(string storageLocation = "C:\\temp\\testformax.txt")
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("https://gist.githubusercontent.com/ic2000/34c02f9d03330efdd5b43a5b1f5cf148/raw/b2e13ce73e00c5aa72b0dfbdb295b5bc8ef594b1/testformax", storageLocation);
            }
        }

        public string Read(string fileLocation = "C:\\temp\\testformax.txt")
        {
            var text = "";
            var fileStream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            return text;
        }

    }
}
