namespace DataService.dtos.ProductOptionItem
{
    public class ProductOptionItemCreateDto
    {
        public int Order { get; set; }
        public int ProductOptionId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}