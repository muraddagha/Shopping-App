namespace DataService.dtos.ProductPhotos
{
    public class ProductPhotosUpdateDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int OrderBy { get; set; }
    }
}