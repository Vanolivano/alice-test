using alice.Extensions;
using alice.Models;
using Microsoft.AspNetCore.Mvc;

namespace alice.Controllers
{
    public class AliceController : Controller
    {
        [HttpPost("/alice")]
        public AliceResponse WebHook([FromBody] AliceRequest req) => req.Reply("Привет");

        public string Index()
        {
            return "Hello world";
        }

    }
}
