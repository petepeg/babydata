namespace BabyData.ExtentionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime TrimSeconds(this DateTime a)
        {
            return new DateTime(a.Year, a.Month, a.Day, a.Hour, a.Minute, 0, a.Kind);
        }
    }
    public static class TimeSpanExtensions
    {
        public static string ToHumanReadable(this TimeSpan ts)
        {
            var totalMinuets = ts.TotalMinutes;
            int hours = (int)(totalMinuets / 60);
            int min = (int)(totalMinuets % 60);
            return hours > 0 ? $"{hours} hours and {min} min" : $"{min} min";

        }
    }
}
