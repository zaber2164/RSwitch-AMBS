using Abp.Web.Models;
using RSwitch.AMBS.Library;
using RSwitch.AMBS.Library.camt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using RSwitch.AMBS.DAL.Repositories.Implementation;
using AutoMapper;
using RSwitch.AMBS.Service.Implementation;
using RSwitch_AMBS_Integration.Controllers;
using RSwitch.AMBS.Library.pacs;
using Microsoft.AspNetCore.Authorization;
using RSwitch.AMBS.Model.View;
using RSwitch.AMBS.Service.Interface;

namespace RSwitch.AMBS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RswitchController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBranchService branchService;
        private readonly ILogger<RswitchController> _logger;

        public RswitchController(IMapper mapper, IBranchService _branchService, ILogger<RswitchController> logger)
        {
            _mapper = mapper;
            branchService = _branchService;
            _logger = logger;
        }

        [Route("[action]")]
        [HttpPost]
        [Consumes("application/xml")]
        [Authorize]
        public async Task<ActionResult<IEnumerable< BranchView>>> BusinessMessage([FromBody] GetAccountLookup.BusinessMessage value)
        {
            var branches = await branchService.GetBranchAsync();
            return Ok(branches);
        }
        [Route("[action]")]
        [HttpPost]
        //[DontWrapResult]
        [Consumes("application/xml")]
        public async Task<IActionResult> Test([FromBody] note value)
        {
            return Ok();
        }
        //[HttpGet]
        //[Route("[action]")]
        //public decimal Divide(decimal a, decimal b)
        //{
        //    try
        //    {
        //        return (a / b);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogInformation("Error in Divide Method - Value of a is {a}", a);
        //        _logger.LogInformation("Error in Divide Method - Value of b is {b}", b);
        //        _logger.LogError(ex, "Error in Divide Method");
        //        return 0;
        //    }
        //}
    }
}
