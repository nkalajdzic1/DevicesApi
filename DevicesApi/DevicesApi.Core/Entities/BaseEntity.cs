namespace DevicesApi.Core.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; } = "SYSTEM";
        public DateTime ModifiedAt { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; } = "SYSTEM";
        public DateTime ArchivedAt { get; set; } = DateTime.Now;
        public string? ArchivedBy { get; set; } = null;
    }
}
