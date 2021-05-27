using System;
using TPAPI.Entities;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace TPAPI.Data
{
    public class JokeApi
    {
        private string joke;


        public string Joke()
        {
            var url = $"https://geek-jokes.sameerkumar.website/api?format=json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Joke joke = JsonConvert.DeserializeObject<Joke>(responseBody);
                            return joke.joke;

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        public JokeApi()
        {
            this.joke = this.Joke();
        }

        public string GetJoke()
        {
            return this.joke;
        }

    }
}
