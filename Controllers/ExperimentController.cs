using Gvz.Laboratory.ExperimentService.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Gvz.Laboratory.ExperimentService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperimentController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateExperimentAsync([FromBody] ExperimentCreateRequest experimentCreateRequest)
        {
            throw new Exception();
        }
    }
}
