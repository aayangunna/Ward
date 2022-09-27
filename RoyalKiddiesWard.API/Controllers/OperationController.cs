using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalKiddiesWard.API.ViewModels;
using RoyalKiddiesWard.Application.Services.Interfaces;

namespace RoyalKiddiesWard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IWardService wardService;

        public OperationController(IWardService wardService)
        {
            this.wardService = wardService;
        }


        //[HttpPut]
        //public Task<IActionResult> BuyAirtime([FromBody] Airtime AirtimeDetails)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        wardService.GetAirtime(AirtimeDetails.
        //    }
        //}
    } 
}
