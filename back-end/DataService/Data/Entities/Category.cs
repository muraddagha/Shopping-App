using DataService.Enums;

namespace DataService.Data.Entities
{
    public class Category : BaseEntity
    {
        public string FilePath { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}