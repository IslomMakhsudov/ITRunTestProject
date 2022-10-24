namespace PetShop.Services
{
    public class LoginService
    {
        public LoginService()
        {

        }
        public string PersonLogin(HttpRequest httpRequest)
        {
            var database = new Database();  
            
            /*var form = context.Request.Form;
            if (!form.ContainsKey("email") && !form.ContainsKey("password"))
                return "Email или Password не установлен";

            string login = form["email"];
            string password = form["password"];*/

            var person = database.GetAllPersons().FirstOrDefault(x=>x.Login == "Login" && x.Password == "1234");
            if (person is null)
                return "/123";

            return "/Values";
        }

        public void Test(HttpContext context)
        {
            
        }
    }
}
