using Microsoft.AspNetCore.Mvc;

namespace TrainingPlanner.API.Controllers;

[ApiController]
[Route("plans")]
public class TrainingController : ControllerBase
{
    [HttpGet("TEST")]
    public ActionResult<object> GetTest()
    {
        return "test";
    }
}
