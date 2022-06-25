using EverfieldAPI.Models.ApiRequests;
using EverfieldAPI.Models.ApiResponse;

namespace EverfieldAPI.Services
{
    public interface IOfferService
    {
        Task<OfferResponse> GetOffer(OfferModel payload);
    }
}
