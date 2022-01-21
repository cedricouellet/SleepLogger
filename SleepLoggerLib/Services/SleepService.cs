using SleepLoggerLib.Models;

namespace SleepLoggerLib.Services
{
    [Serializable]
    public class SleepService : ISleepService
    {
        private readonly IList<SleepRecord> _records;

        public SleepService()
        {
            _records = new List<SleepRecord>();
        }

        public void Add(SleepRecord record)
        {
            _records.Add(record);
        }

        public int GetCount()
        {
            return _records.Count;
        }

        public void Remove(SleepRecord record)
        {
            _records.Remove(record);
        }

        public void Remove(string id)
        {
            SleepRecord? toDelete = _records.FirstOrDefault(rec => rec.Id == id);

            if (toDelete == null) return;

            int index = _records.IndexOf(toDelete);
            _records.RemoveAt(index);
        }

        public SleepRecord? Get(string id)
        {
            return _records.FirstOrDefault(rec => rec.Id == id);
        }

        public IEnumerable<SleepRecord> GetAll()
        {
            return _records;
        }

        public SleepRecord? GetLast()
        {
            return _records.LastOrDefault();
        }

        public void RemoveAll()
        {
            _records.Clear();
        }
    }
}