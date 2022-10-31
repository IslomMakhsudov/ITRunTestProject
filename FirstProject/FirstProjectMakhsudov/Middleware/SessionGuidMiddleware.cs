namespace PetShop.Middleware
{
    public class SessionGuidMiddleware
    {
        private readonly RequestDelegate next;

        Database _database;

        public SessionGuidMiddleware(RequestDelegate next, Database database)
        {
            this.next = next;
            _database = database;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            if (context.Request.Path != "Values/registration" || context.Request.Path != "Values/login")
            {
                if (!context.Session.Keys.Contains("guid"))
                {
                    context.Response.StatusCode = 404;
                    await context.Response.WriteAsync("! ! ! Cannot find GUID ! ! !");
                }
                else
                {
                    var _people = _database.GetAllPersons();
                    var guid = context.Session.GetString("guid");
                    bool tf = false;
                    foreach (var person in _people)
                        if (person.Id.ToString() == guid) { tf = true; break; }

                    if (tf)
                    {
                        context.Response.StatusCode = 404;
                        await context.Response.WriteAsync("! ! ! GUID already exists ! ! !");
                    }
                    else
                    {
                        await next.Invoke(context);
                    }
                }
            }
            else
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Error!");

                if (!context.Session.Keys.Contains("guid"))
                {
                    context.Response.StatusCode = 404;
                    await context.Response.WriteAsync("! ! ! Cannot find GUID ! ! !");
                }
                else
                {
                    var _people = _database.GetAllPersons();
                    var guid = context.Session.GetString("guid");
                    bool tf = false;
                    foreach (var person in _people)
                        if (person.Id.ToString() == guid) { tf = true; break; }

                    if (tf)
                    {
                        context.Response.StatusCode = 404;
                        await context.Response.WriteAsync("! ! ! GUID already exists ! ! !");
                    }
                    else
                    {
                        await next.Invoke(context);
                    }

                }
            }
        }
    }
}