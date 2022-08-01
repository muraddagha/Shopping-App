namespace DataService.dtos.ProductPhotos
{
    public class ProductPhotosCreateDto
    {
        public int ProductId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int OrderBy { get; set; }
    }
}