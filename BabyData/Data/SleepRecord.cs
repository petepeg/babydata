using BabyData.ExtentionMethods;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyData.Data
{
    public class SleepRecord : UtcAndLocalDateTimeRecord
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}
