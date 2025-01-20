using ApexCharts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BabyData.Data
{
    [Index(nameof(Title), IsUnique = true)]
    public class Tag
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}
