using BabyData.ExtentionMethods;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyData.Data
{
    public class FeedingRecord
    {
        public FeedingRecord()
        {
            var now = DateTime.Now.ToUniversalTime();
            now = now.TrimSeconds();
            this.StartTimeUtc = now;
            this.EndTimeUtc = now;
            LocalDateTimes = new FeedingRecordLocalDateTimes();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public DateTime StartTimeUtc { get; private set; }
        public DateTime EndTimeUtc { get; private set; }
        public FeedingType FeedingType { get; set; }
        public decimal QuantityInOz { get; set; }
        public string Notes { get; set; } = string.Empty;

        public TimeSpan ElapsedTime => EndTimeUtc - StartTimeUtc;

        [NotMapped]
        public FeedingRecordLocalDateTimes LocalDateTimes { get; set; }
        public void SetTimeUtcFromLocal(TimeZoneInfo sourceTimeZoneInfo)
        {
            StartTimeUtc = TimeZoneInfo.ConvertTimeToUtc(LocalDateTimes.StartTimeLocal, sourceTimeZoneInfo);
            EndTimeUtc = TimeZoneInfo.ConvertTimeToUtc(LocalDateTimes.EndTimeLocal, sourceTimeZoneInfo);
        }
        public void SetTimeLocalFromUtc(TimeZoneInfo timeZoneInfo)
        {
            LocalDateTimes.StartTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(StartTimeUtc, timeZoneInfo);
            LocalDateTimes.EndTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(EndTimeUtc, timeZoneInfo);
            
            
        }

    }

    public class FeedingRecordLocalDateTimes
    {
        public DateTime StartTimeLocal { get; set; }
        public string StartTimeString => StartTimeLocal.ToString("hh:mm tt");

        public DateTime EndTimeLocal { get; set; }
        public string EndTimeString => EndTimeLocal.ToString("hh:mm tt");

        public TimeSpan ElapsedTime => EndTimeLocal - StartTimeLocal;

        public void NudgeStartTime (int min)
        {
            StartTimeLocal += TimeSpan.FromMinutes(min);
        }

        public void NudgeEndTime(int min)
        {
            EndTimeLocal += TimeSpan.FromMinutes(min);
        }

    }

    public enum FeedingType
    {
        None = 0,
        Breast = 1,
        Bottle = 2,
        Solid = 3,
    }
}
