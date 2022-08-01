using System.Collections.Generic;
using DataService.dtos.ProductOptionItem;
using DataService.Enums;

namespace DataService.dtos.ProductOption
{
    public class ProductOptionDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public OptionsType Type { get; set; }
        public ICollection<ProductOptionItemDto> ProductOptionItems { get; set; }

    }
}