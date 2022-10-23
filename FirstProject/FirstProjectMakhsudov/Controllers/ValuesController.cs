using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string Index()
        {
            return "Index page";
        }

        [Route("registration/")]
        public void Registration()
        {
            var registrService = new RegistrationService();
            var database = new Database();

            registrService.PersonRegistration();
            Results.Ok(database.GetAllPersons().Count.ToString());

        }
        [Route("login/")]
        public void Login()
        {
            var login = new LoginService();
            Results.Redirect(login.PersonLogin());
        }
    }
}
