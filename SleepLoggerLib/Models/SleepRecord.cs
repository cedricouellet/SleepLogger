namespace SleepLoggerLib.Models
{
    [Serializable]
    public record SleepRecord
    {
        public readonly string Id;          // Guid
        public readonly string Date;        // DateOnly
        public readonly string Bedtime;     // TimeOnly
        public readonly string WakeTime;    // TimeOnly

        public float TimeAsleep
        {
            get
            {
                TimeSpan diff = this.WakeTime() - this.Bedtime();
                return (float)Math.Round(diff.Hours * 2f) * 0.5f;
            }
        }

        public SleepRecord(DateOnly date, TimeOnly bedtime, TimeOnly wakeTime)
        {
            Id = Guid.NewGuid().ToString();
            Date = date.ToString();
            Bedtime = bedtime.ToString();
            WakeTime = wakeTime.ToString();
        }

        public override string ToString()
        {
            return $"[{TimeAsleep:00} hours] {Date} from {Bedtime} to {WakeTime}";
        }
    }

    public static class SleepRecordExtensions
    {
        public static TimeOnly Bedtime(this SleepRecord record)
        {
            return TimeOnly.Parse(record.Bedtime);
        }

        public static TimeOnly WakeTime(this SleepRecord record)
        {
            return TimeOnly.Parse(record.WakeTime);
        }

        public static DateOnly Date(this SleepRecord record)
        {
            return DateOnly.Parse(record.Date);
        }
    }
}