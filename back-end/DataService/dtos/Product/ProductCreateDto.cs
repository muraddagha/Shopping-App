namespace DataService.dtos.Product
{
    public class ProductCreateDto
    {
        public int Order { get; set; }
        public int CategoryId { get; set; }

        public int BrandId { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
        public double Rating { get; set; }

        public string Description { get; set; }
        public bool IsAviable { get; set; }
    }
}