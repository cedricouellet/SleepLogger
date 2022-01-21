using SleepLoggerLib.Models;

namespace SleepLoggerLib.Services
{
    public interface IStatisticsService
    {
        TimeOnly? GetAverageBedtime();

        float GetAverageTimeAsleep();
        TimeOnly? GetAverageWakeTime();

        SleepRecord? GetBest();

        SleepRecord? GetWorst();
    }
}