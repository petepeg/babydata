﻿using BabyData.ExtentionMethods;
using System.ComponentModel.DataAnnotations;

namespace BabyData.Data
{
    public class FeedingRecord
    {
        public FeedingRecord()
        {
            var now = DateTime.Now;
            now = now.TrimSeconds();
            this.StartTime = TimeOnly.FromDateTime(now);
            this.EndTime = TimeOnly.FromDateTime(now);
            this.Date = DateOnly.FromDateTime(now);
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateOnly Date {  get; set; }
        public FeedingType FeedingType { get; set; }
        public decimal QuantityInOz { get; set; }
        public string Notes { get; set; } = string.Empty;

        public TimeSpan ElapsedTime => EndTime - StartTime;
    }

    public enum FeedingType
    {
        None = 0,
        Breast = 1,
        Bottle = 2,
        Solid = 3,
    }
}
