namespace DataService.dtos.Sale
{
    public class SaleCreateDto
    {
        public int UserId { get; set; }
        public double TotalSalePrice { get; set; }
        public int Order { get; set; }
    }
}