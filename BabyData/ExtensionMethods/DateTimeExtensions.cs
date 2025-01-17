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
            int mins = (int)(totalMinuets % 60);

            
            if( hours == 0 )
            {
                return $"{mins} mins";
            }
            if (hours != 0 && mins == 0)
            {
                return $"{hours} hours";
            }

            return  $"{hours} hours and {mins} min";

        }
    }
}
