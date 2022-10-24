using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.Models.Dto;

namespace PetShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        LoginService loginService;
        RegistrationService registrationService;
        Database database;
        public ValuesController(LoginService loginService, RegistrationService registrationService, Database database)
        {
            this.loginService = loginService;
            this.registrationService = registrationService;
            this.database = database;
        }
        public string Index()
        {
            
            return "Index page";
        }

        [Route("registration")]
        public IActionResult Registration(RegistrationDto registration)
        {
            registrationService.PersonRegistration(registration);
            return Ok(database.GetAllPersons().Count.ToString());
        }
        [Route("login")]
        public void Login()
        {
            Results.Redirect(loginService.PersonLogin());
        }
    }
}
