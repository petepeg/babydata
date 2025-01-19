using ApexCharts;

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
                return $"{mins}m";
    
            if (hours != 0 && mins == 0)
                return $"{hours}h";

            return  $"{hours}h {mins}m";

        }

        public static string ToHumanReadableLong(this TimeSpan ts)
        {
            var totalMinuets = ts.TotalMinutes;
            int hours = (int)(totalMinuets / 60);
            int mins = (int)(totalMinuets % 60);

            var minOut = $"{mins} minute";
            minOut = mins > 1 ? minOut + "s" : minOut;

            var hrsOut = $"{hours} hour";
            hrsOut =  hours > 1 ? hrsOut + "s" : hrsOut;

            if (hours == 0)
                return minOut;

            if (hours != 0 && mins == 0)
                return hrsOut;

            return hrsOut + " " + minOut;

        }
    }
}
