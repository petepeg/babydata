using System.ComponentModel.DataAnnotations;

namespace BabyData.Data
{
    public class FeedingRecord
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date {  get; set; }
        public FeedingType FeedingType { get; set; }
        public string Notes { get; set; } = string.Empty;
    }

    public enum FeedingType
    {
        None = 0,
        Breast = 1,
        Bottle = 2,
        Solid = 3,
    }
}
