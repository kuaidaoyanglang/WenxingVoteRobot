using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WenxingFlash
{
    class Utility
    {
        const string FirefoxUA = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:{0}.0) Gecko/20100101 Firefox/{0}.0";
        const string RandomUA = "Mozilla/5.0 ({0} NT 6.1; WOW64; rv:{3}.0) {1}/20100101 {2}/{3}.0";
        private static string[] ChromeUA = { "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36",
            "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2225.0 Safari/537.36",
            "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/35.0.2117.157 Safari/537.36",
            "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/40.0.2214.93 Safari/537.36",
            "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2224.3 Safari/537.36",
            "Mozilla/5.0 (Windows NT 5.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/35.0.3319.102 Safari/537.36" };
        public static string RandomUserAgent()
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 1))
            {
                case 0:
                    return string.Format(FirefoxUA, rnd.Next(38, 42));
                case 1:
                    return ChromeUA[rnd.Next(0, ChromeUA.Length - 1)];
                default:
                    return string.Format(RandomUA, RandomString(7), RandomString(5), RandomString(7), rnd.Next(5, 42));
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static async Task<Bitmap> HTTPGetPngAsync(string userAgent, string uri, CookieContainer cookies)
        {
            using (Stream responseStream = await HTTPGetStream(userAgent, "image/png", uri, cookies))
            {
                return await Task.Run(() => (Bitmap)Image.FromStream(responseStream));
            }
        }

        public static async Task<string> HTTPGetStringAsync(string userAgent, string uri, CookieContainer cookies)
        {
            using (Stream responseStream = await HTTPGetStream(userAgent, "text/html",uri,cookies))
            using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static async Task<Stream> HTTPGetStream(string userAgent, string contentType, string uri, CookieContainer cookies)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.Proxy = null;
            request.UserAgent = userAgent;
            request.ContentType = contentType;
            request.CookieContainer = cookies;
            HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
            cookies.Add(response.Cookies);
            return response.GetResponseStream();
        }
    }
}
