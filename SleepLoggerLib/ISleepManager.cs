using SleepLoggerLib.Models;

namespace SleepLoggerLib
{
    public interface ISleepManager
    {
        void AddRecord(DateOnly date, TimeOnly bedtime, TimeOnly wakeTime);

        int CountRecords();

        IEnumerable<SleepRecord> GetAllRecords();

        Tuple<int, int>? GetAverageBedtime();

        float GetAverageTimeAsleep();

        Tuple<int, int>? GetAverageWakeTime();

        SleepRecord? GetBestRecord();

        SleepRecord? GetLastRecord();

        SleepRecord? GetRecord(string id);

        SleepRecord? GetWorstRecord();

        void RemoveAllRecords();

        void RemoveRecord(string id);

        void RemoveRecord(SleepRecord record);

        public void Save();
    }
}