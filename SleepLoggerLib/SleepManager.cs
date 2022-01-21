using SleepLoggerLib.Helpers;
using SleepLoggerLib.Services;
using SleepLoggerLib.Models;

namespace SleepLoggerLib
{
    public class SleepManager : ISleepManager
    {
        private readonly ISleepService _sleepService;
        private readonly IStatisticsService _statisticsService;

        private SleepManager(ISleepService? sleepService = null)
        {
            _sleepService = sleepService ?? new SleepService();
            _statisticsService = new StatisticsService(_sleepService);
        }

        public static string DataFile { get; set; } = "SleepManager.data";

        public static SleepManager Instance
        {
            get
            {
                try
                {
                    ISleepService? loadedSleepService = SerializationHelper.Load<ISleepService>(DataFile);
                    return new SleepManager(loadedSleepService);
                }
                catch (FileNotFoundException)
                {
                    return new SleepManager();
                }
            }
        }

        public int CountRecords()
        {
            return _sleepService.GetCount();
        }

        public void AddRecord(DateOnly date, TimeOnly bedtime, TimeOnly wakeTime)
        {
            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);
            _sleepService.Add(record);
        }

        public IEnumerable<SleepRecord> GetAllRecords()
        {
            return _sleepService.GetAll();
        }

        public Tuple<int, int>? GetAverageBedtime()
        {
            return _statisticsService.GetAverageBedtime()?.ToTuple();
        }

        public float GetAverageTimeAsleep()
        {
            return _statisticsService.GetAverageTimeAsleep();
        }

        public Tuple<int, int>? GetAverageWakeTime()
        {
            return _statisticsService.GetAverageWakeTime()?.ToTuple();
        }

        public SleepRecord? GetLastRecord()
        {
            return _sleepService.GetLast();
        }

        public SleepRecord? GetRecord(string id)
        {
            return _sleepService.Get(id);
        }

        public void RemoveAllRecords()
        {
            _sleepService.RemoveAll();
        }

        public void RemoveRecord(string id)
        {
            _sleepService.Remove(id);
        }

        public void RemoveRecord(SleepRecord record)
        {
            _sleepService.Remove(record);
        }

        public void Save()
        {
            SerializationHelper.Dump(DataFile, _sleepService);
        }

        public SleepRecord? GetBestRecord()
        {
            return _statisticsService.GetBest();
        }

        public SleepRecord? GetWorstRecord()
        {
            return _statisticsService.GetWorst();
        }
    }
}