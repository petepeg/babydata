using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BabyData.Data
{
    public class DiaperTag
    {
        [Key]
        public Guid Id { get; set; }
        public Tag Tag { get; set; }
        public DiaperRecord DiaperRecord { get; set; }
    }
}
