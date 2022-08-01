using System.Collections.Generic;

namespace DataService.Data.Entities
{
    public class Sale : BaseEntity
    {
        public int UserId { get; set; }
        public double TotalSalePrice { get; set; }
        public User User { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
    }
}