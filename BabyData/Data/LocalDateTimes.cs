namespace BabyData.Data
{
    public class LocalDateTimes
    {

        public TimeSpan ElapsedTime => EndTimeLocal - StartTimeLocal;

        public DateTime EndTimeLocal { get; set; }
        public string EndTimeString => EndTimeLocal.ToString("hh:mm tt");
        public DateTime StartTimeLocal { get; set; }
        public string StartTimeString => StartTimeLocal.ToString("hh:mm tt");
    }
}