using System.ComponentModel.DataAnnotations;

namespace BabyData.Data
{
    public class DiaperRecord : UtcAndLocalDateTimeRecord, IHaveBabyData
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public string ColorCode { get; set; }
        public string Notes { get; set; }
        public decimal Weight { get; set; }
        public ICollection<DiaperTag> Tags { get; }
    }
}
