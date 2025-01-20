using BabyData.ExtentionMethods;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyData.Data
{
    public class FeedingRecord : UtcAndLocalDateTimeRecord, IHaveBabyData
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public FeedingType FeedingType { get; set; }
        public decimal QuantityInOz { get; set; }
        public string Notes { get; set; } = string.Empty;
        public BreastSelection BreastSelection { get; set; }
    }

    public enum FeedingType
    {
        None = 0,
        Breast = 1,
        Bottle = 2,
        Solid = 3,
    }

    public enum BreastSelection
    {
        None = 0,
        Left = 1,
        Right = 2,
        Both = 3,
    }
}
