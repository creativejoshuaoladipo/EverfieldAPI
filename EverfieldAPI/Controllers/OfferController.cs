using EverfieldAPI.Attributes;
using EverfieldAPI.Models.ApiRequests;
using EverfieldAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverfieldAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    //[ApiKeyAttribute]
    public class OfferController : ControllerBase
    {
        private readonly IOfferService _offerService;


        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }


        [Route("GetOffer")]
        [HttpPost]
        public async Task<dynamic> GetOffer([FromBody] OfferModel request)
        {
            var ServiceResponce = await _offerService.GetOffer(request);
            return ServiceResponce;
        }

       
    }
}
