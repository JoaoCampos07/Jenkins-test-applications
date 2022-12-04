using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class HealthController : Controller
    {
        [HttpGet]
        [Route("readiness")]
        public ActionResult Readiness()
        {
            return Ok("Ready");
        }

        [HttpGet]
        [Route("liveliness")]
        public ActionResult Liveliness(int id)
        {
            return Ok("ALive");
        }
    }
}
