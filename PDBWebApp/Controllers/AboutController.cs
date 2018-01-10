using Microsoft.AspNetCore.Mvc;

namespace PDBWebApp.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {

        public string Phone()
        {
            return "123456789";
        }
        [Route("[action]")]
        public string Adress()
        {
            return "Zara Foreva";
        }
    }
}
