using System;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace eKreta
{
    class User
    {
        private string username;
        private string password;
        private string ist;

        private string userAgent = "hu.ekreta.student/1.0.5";
        private string clientID = "kreta-ellenorzo-mobile-android";

        public string bearer;

        public User(string username, string password, string ist)
        {
            this.username = username;
            this.password = password;
            this.ist = ist;
        }

        public void LoadBearer()
        {
            var task = getToken();
            var res = task.Result;
            bearer = JsonConvert.DeserializeObject<Dictionary<string, string>>(res)["access_token"];
        }

        public async Task<string> getToken()
        {
            string nonce = getNonce();

            byte[] key = new byte[] { 98, 97, 83, 115, 120, 79, 119, 108, 85, 49, 106, 77 };
            byte[] message = Encoding.UTF8.GetBytes(ist.ToUpper() + nonce + username.ToUpper());

            var e = new HMACSHA512(key).ComputeHash(message);
            var generated = Convert.ToBase64String(e);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(Kreta.IDP + KretaEndpoints.token),
                Headers =
                {
                    { "User-Agent", userAgent },
                    { "X-AuthorizationPolicy-Key", generated},
                    { "X-AuthorizationPolicy-Version", "v2" },
                    { "X-AuthorizationPolicy-Nonce", nonce },
                },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "userName", username },
                    { "password", password },
                    { "institute_code", ist },
                    { "grant_type", "password" },
                    { "client_id", clientID },
                }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return body;
            }
        }

        public void Print() {
            Console.WriteLine("Username: " + username);
            Console.WriteLine("Password: " + password);
            Console.WriteLine("IST: " + ist);
            Console.WriteLine("Token: " + getToken());
        }

        private string getNonce()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://idp.e-kreta.hu" + KretaEndpoints.nonce);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
