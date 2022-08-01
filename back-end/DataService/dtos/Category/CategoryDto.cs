using DataService.dtos.Department;

namespace DataService.dtos.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string FilePath { get; set; }

        public int DepartmentId { get; set; }

        public DepartmentDto Department { get; set; }
        public int Order { get; set; }

    }
}