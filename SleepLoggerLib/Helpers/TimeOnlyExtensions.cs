namespace SleepLoggerLib.Helpers
{
    public static class TimeOnlyExtensions
    {
        public static Tuple<int, int> ToTuple(this TimeOnly timeOnly)
        {
            return new Tuple<int, int>(timeOnly.Hour, timeOnly.Minute);
        }
    }
}
