namespace DataService.Data.Entities
{
    public class Slider : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
        public int ButtonId { get; set; }
        public Department Department { get; set; }
    }
}