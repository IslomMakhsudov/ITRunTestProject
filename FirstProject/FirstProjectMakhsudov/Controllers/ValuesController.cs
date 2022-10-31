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
        DatabaseHandler databaseHandler;
        public ValuesController(LoginService loginService, RegistrationService registrationService, Database database, DatabaseHandler databaseHandler)
        {
            this.loginService = loginService;
            this.registrationService = registrationService;
            this.database = database;
            this.databaseHandler = databaseHandler;
        }
        public string Index()
        {   
            return "Index page";
        }

        [Route("registration")]
        public IActionResult Registration([FromBody] RegistrationDto registration)
        {
            registrationService.PersonRegistration(registration);
            return Ok(database.GetAllPersons().Count.ToString());
        }
        [Route("login")]
        public IActionResult Login([FromQuery] string password, string login)
        {
            bool result = loginService.PersonLogin(password, login);
            if (result) return Ok();
            return BadRequest();
        }
    }
}
