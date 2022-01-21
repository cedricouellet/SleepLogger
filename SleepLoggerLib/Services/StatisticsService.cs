using SleepLoggerLib.Models;

namespace SleepLoggerLib.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly ISleepService _sleepService;

        public StatisticsService(ISleepService sleepService)
        {
            _sleepService = sleepService;
        }

        public SleepRecord? GetWorst()
        {
            if (_sleepService.GetCount() == 0) return null;

            return _sleepService.GetAll().OrderBy(rec => rec.TimeAsleep).First();
        }

        public SleepRecord? GetBest()
        {
            if (_sleepService.GetCount() == 0) return null;

            return _sleepService.GetAll().OrderByDescending(rec => rec.TimeAsleep).First();
        }

        public float GetAverageTimeAsleep()
        {
            if (_sleepService.GetCount() == 0) return default;

            return _sleepService.GetAll().Average(rec => rec.TimeAsleep);
        }

        public TimeOnly? GetAverageBedtime()
        {
            if (_sleepService.GetCount() == 0) return null;

            double averageTicks = _sleepService.GetAll().Select(rec => rec.Bedtime().Ticks).Average();
            TimeSpan ts = TimeSpan.FromTicks((long)averageTicks);
            return TimeOnly.FromTimeSpan(ts);

        }

        public TimeOnly? GetAverageWakeTime()
        {
            if (_sleepService.GetCount() == 0) return null;

            double averageTicks = _sleepService.GetAll().Select(rec => rec.WakeTime().Ticks).Average();
            TimeSpan ts = TimeSpan.FromTicks((long)averageTicks);
            return TimeOnly.FromTimeSpan(ts);
        }
    }
}
