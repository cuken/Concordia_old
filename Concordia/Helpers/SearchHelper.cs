using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Concordia.Helpers
{
    class SearchHelper
    {
        public static async Task<Stream> GetResponseStream(string v)
        {
            var wr = (HttpWebRequest)WebRequest.Create(v);
            try
            {
                return (await (wr).GetResponseAsync()).GetResponseStream();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error in getresponse stream " + ex);
                return null;
            }
        }

        public static async Task<string> GetResponseAsync(string v) =>
            await new StreamReader((await ((HttpWebRequest)WebRequest.Create(v)).GetResponseAsync()).GetResponseStream()).ReadToEndAsync();

        public static async Task<string> GetResponseAsync(string v, WebHeaderCollection headers)
        {
            var wr = (HttpWebRequest)WebRequest.Create(v);
            wr.Headers = headers;
            return await new StreamReader((await wr.GetResponseAsync()).GetResponseStream()).ReadToEndAsync();
        }
    }
}
