using Microsoft.AspNetCore.Mvc;

namespace MVC_PICA.Controllers
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute(string permission)
            : base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { permission };
        }
    }
}