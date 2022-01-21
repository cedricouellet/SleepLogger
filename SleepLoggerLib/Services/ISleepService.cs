using SleepLoggerLib.Models;

namespace SleepLoggerLib.Services
{
    public interface ISleepService
    {
        void Add(SleepRecord record);

        int GetCount();

        void Remove(SleepRecord record);

        void Remove(string id);

        SleepRecord? Get(string id);

        IEnumerable<SleepRecord> GetAll();

        SleepRecord? GetLast();

        void RemoveAll();
    }
}