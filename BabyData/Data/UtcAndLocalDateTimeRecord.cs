using BabyData.ExtentionMethods;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyData.Data
{
    public abstract class UtcAndLocalDateTimeRecord
    {
        protected UtcAndLocalDateTimeRecord()
        {
            var now = DateTime.Now.ToUniversalTime();
            now = now.TrimSeconds();
            this.StartTimeUtc = now;
            this.EndTimeUtc = now;
            LocalDateTimes = new LocalDateTimes();
        }
        public DateTime StartTimeUtc { get; set; }
        public DateTime EndTimeUtc { get; set; }
        public TimeSpan ElapsedTime => EndTimeUtc - StartTimeUtc;
        [NotMapped]
        public LocalDateTimes LocalDateTimes { get; set; }

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
}
