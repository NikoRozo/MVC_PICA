using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVC_PICA.Controllers
{
    public class AuthorizeActionFilter : IAuthorizationFilter
    {        
        private readonly string _permission;
    
        public AuthorizeActionFilter(string permission)
        {            
            _permission = permission;
        }
    
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //bool isAuthorized = CheckUserPermission(context.HttpContext.User, _permission);
    
            if (!(context.HttpContext.User is null))
            {
                //context.Result = new UnauthorizedResult();
                context.Result = new CustomUnauthorizedResult("No esta Autorizado, debe logearse");
            }
        }
    
        private bool CheckUserPermission(ClaimsPrincipal user, string permission)
        {
            if (user is null)
            {
                throw new System.ArgumentNullException(nameof(user));
            }

            /*if (string.IsNullOrEmpty(permission))
            {
                throw new System.ArgumentException("message", nameof(permission));
            }
            // Logic for checking the user permission goes here. 

            // Let's assume this user has only read permission.
            return permission == "Read";*/
            return true;
        }
    }

    public class CustomUnauthorizedResult : JsonResult
    {
        public CustomUnauthorizedResult(string message)
            : base(new CustomError(message))
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }
    }

    public class CustomError
    {
        public string Error { get; }

        public CustomError(string message)
        {
            Error = message;
        }
    }
}