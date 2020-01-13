using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WebApplication4.Models
{
    public class Request
    {
        public Pokemon RecievePokemon(string Pokemon)
        {
            string Url = "https://pokeapi.co/api/v2/";

            WebRequest webRequest = WebRequest.Create(Url + Pokemon);

            WebResponse webResponse = webRequest.GetResponse();

            Stream stream = webResponse.GetResponseStream();

            StreamReader reader = new StreamReader(stream);

            string responsefromserver = reader.ReadToEnd();

            JObject parsedstring = JObject.Parse(responsefromserver);

            Pokemon myPokemon = parsedstring.ToObject<Pokemon>();

            return myPokemon;
        }
    }
}