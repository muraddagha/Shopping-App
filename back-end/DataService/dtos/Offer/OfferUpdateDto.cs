namespace DataService.dtos.Offer
{
    public class OfferUpdateDto
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}