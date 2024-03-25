using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace UsgaiService.Controllers.Chiikawa
{
    [ApiController]
    [Route("Chiikawa/[controller]")]
    public class UsagiController:ControllerBase
    {
        private readonly ILogger<UsagiController> _logger;

        public UsagiController(ILogger<UsagiController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult  Get() 
        {
            return Content("Hello Usagi!");
        }
        [HttpPost]
        public ActionResult Query() 
        {
            return Content("Hello Chiikawa!");
        }
        [HttpPost]
        public bool Insert(string request) 
        {
            return true;
        }
    }
}
