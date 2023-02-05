using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MesOutils
{
    class UtilitaireAPI
    {
        public static string RecupereLoremIpsum(int nbParagraphes)
        {
            HttpClient client = new HttpClient();


            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/text"));
            String url = $"https://loripsum.net/api/{nbParagraphes}/short/plaintext";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;

                return responseBody;
            }
            else
            {
                throw new Exception("Erreur API : " + response.StatusCode + " " + response.ReasonPhrase);
            }
        }
        internal static string InversePhrase(string phrase)
        {
            string message = "";
            var tab = phrase.Split(' ');
            foreach (string mot in tab)
            {
                message = mot + " " + message;
            }
            return message;
        }

        static void TesteInversePhrase()
        {
            try
            {
                string phrase = RecupereLoremIpsum(3);
                Console.WriteLine(phrase);
                string phraseInversee = InversePhrase(phrase);
                Console.WriteLine(phraseInversee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
