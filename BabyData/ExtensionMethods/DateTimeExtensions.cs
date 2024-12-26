namespace BabyData.ExtentionMethods
{
    public static class DateTimeExtensions
    {
        public static DateTime TrimSeconds(this DateTime a)
        {
            return new DateTime(a.Year, a.Month, a.Day, a.Hour, a.Minute, 0, a.Kind);
        }
    }
}
