using EverfieldAPI.Models.ApiRequests;
using EverfieldAPI.Models.ApiResponse;

namespace EverfieldAPI.Services
{
    public class OfferService : IOfferService
    {
        public OfferService()
        {

        }
        private static List<OfferModel> offers = new List<OfferModel>();
    
        public async Task<OfferResponse> GetOffer(OfferModel payload)
        {
            var serviceResponse = new OfferResponse();
            offers.Add(payload);
            serviceResponse.Total = 5.0M;

            return serviceResponse;
        }

       
    }
}
