using System.Web.Mvc;
using WebApplication4.Models;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var test = RecievePokemon("bulbasaur");
            return View(test);
        }

        public Pokemon RecievePokemon(string Pokemon)
        {
            string Url = "https://pokeapi.co/api/v2/pokemon/";

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