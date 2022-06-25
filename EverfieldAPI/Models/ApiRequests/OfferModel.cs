namespace EverfieldAPI.Models.ApiRequests
{
    public class OfferModel
    {
        public string ContactAddress { get; set; }
        public string WarehouseAddress { get; set; }
        public Package[] Dimensions { get; set; } 
    }

    public class Package
    {
        public decimal Height { get; set; } 
        public decimal Width { get; set; } 
        public decimal Depth { get; set; }
    }
}
