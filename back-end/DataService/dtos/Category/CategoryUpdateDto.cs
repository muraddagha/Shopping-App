namespace DataService.dtos.Category
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string FilePath { get; set; }
        public int DepartmentId { get; set; }
    }
}