using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MCV.Models;

namespace MCV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/Api/Contact")] 
        public IActionResult Create(ContactModel model) 
        { 
            if (model.FirstName is null || model.LastName is null || model.Email is null || model.Message is null)
            {
                return NotFound();
            }
            return Accepted(new {message = model.FirstName + " Su mensaje fue Enviado"}); 
        } 
    }
}
