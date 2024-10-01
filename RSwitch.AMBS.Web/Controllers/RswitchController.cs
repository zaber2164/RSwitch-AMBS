using Abp.Web.Models;
using Asai.Ambs.RSwitch.Library;
using Asai.Ambs.RSwitch.Library.camt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RSwitch_AMBS_Integration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RswitchController : ControllerBase
    {
        [Route("[action]")]
        [HttpPost]
        [Consumes("application/xml")]
        public async Task<IActionResult> BusinessMessage([FromBody] GetAccountLookup.BusinessMessage value)
        {
            return Ok();
        }
        [Route("[action]")]
        [HttpPost]
        //[DontWrapResult]
        [Consumes("application/xml")]
        public async Task<IActionResult> Test([FromBody] note value)
        {
            return Ok();
        }
    }
}
