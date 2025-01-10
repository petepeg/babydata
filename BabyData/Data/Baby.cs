using System.ComponentModel.DataAnnotations;

namespace BabyData.Data
{
    public class Baby
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        public string Name { get; set; } = "";
    }
}
