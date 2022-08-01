namespace DataService.Data.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public int Order { get; set; }

    }
}