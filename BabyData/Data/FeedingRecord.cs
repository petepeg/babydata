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
            this.StartTime = now;
            this.EndTime = now;
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid BabyId { get; set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public FeedingType FeedingType { get; set; }
        public decimal QuantityInOz { get; set; }
        public string Notes { get; set; } = string.Empty;

        public TimeSpan ElapsedTime => EndTime - StartTime;

        [NotMapped]
        public FeedingRecordLocalDateTimes LocalDateTimes { get; set; }
        public void SetTimes()
        {
            StartTime = LocalDateTimes.StartTimeLocal.ToUniversalTime();
            EndTime = LocalDateTimes.EndTimeLocal.ToUniversalTime();
        }

    }

    public class FeedingRecordLocalDateTimes
    {
        public FeedingRecordLocalDateTimes()
        {
                
        }
        // model class cannot contain a public ctor with params  https://github.com/dotnet/aspnetcore/issues/55711
        internal FeedingRecordLocalDateTimes(FeedingRecord feedingRecord, TimeZoneInfo timeZoneInfo)
        {
            StartTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(feedingRecord.StartTime, timeZoneInfo);
            EndTimeLocal = TimeZoneInfo.ConvertTimeFromUtc(feedingRecord.EndTime, timeZoneInfo);
        }
        public DateTime StartTimeLocal { get; set; }
        public DateTime EndTimeLocal { get; set; }
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
