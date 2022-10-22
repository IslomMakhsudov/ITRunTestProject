using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstProjectMakhsudov.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string Index()
        {
            return "Index page";
        }

        [Route("login/")]
        public string Login()
        {

            return "Login successful!";
        }
    }
}
