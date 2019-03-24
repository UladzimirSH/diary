using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase {

        [HttpGet]
        public ActionResult Get() {
            return Ok();
        }
    }
}
