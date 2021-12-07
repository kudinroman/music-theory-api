using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace music_theory_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<dynamic> GetUsers()
        {
            var list = new List<dynamic>();
            var item1 = new
            {
                Name = "Roman",
                Age = 39
            };
            var item2 = new
            {
                Name = "Pavel",
                Age = 29
            };

            list.Add(item1);
            list.Add(item2);

            return list;
        }
    }
}
