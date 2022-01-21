using NUnit.Framework;
using SleepLoggerLib.Services;
using SleepLoggerLib.Models;
using System;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class TestsSleepService
    {
        private static DateTime today = DateTime.Today;
        private static DateOnly date = DateOnly.FromDateTime(today);
        private static TimeOnly bedtime = TimeOnly.FromDateTime(today);
        private static TimeOnly wakeTime = TimeOnly.FromDateTime(today);    

        [Test]
        public void ShouldAdd()
        {
            ISleepService service = new SleepService();
            
            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);
            service.Add(record);

            Assert.IsNotEmpty(service.GetAll());
            Assert.IsTrue(service.GetAll().Contains(record));
            Assert.AreEqual(1, service.GetCount());
            Assert.AreEqual(record, service.GetAll().First());
        }

        [Test]
        public void ShouldDeleteAll()
        {
            ISleepService service = new SleepService();
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));

            Assert.AreEqual(4, service.GetCount());

            service.RemoveAll();

            Assert.IsEmpty(service.GetAll());
            Assert.AreEqual(0, service.GetCount());
        }

        [Test]
        public void ShouldGet()
        {
            ISleepService service = new SleepService();

            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);

            service.Add(record);

            Assert.AreEqual(record, service.Get(record.Id));
        }

        [Test]
        public void ShouldInitialize()
        {
            ISleepService service = new SleepService();

            Assert.IsEmpty(service.GetAll());
            Assert.AreEqual(0, service.GetCount());
        }
        [Test]
        public void ShouldRemove()
        {
            ISleepService service = new SleepService();

            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);

            service.Add(record);

            Assert.AreEqual(1, service.GetCount());

            service.Remove(record);

            Assert.AreEqual(0, service.GetCount());
            Assert.IsFalse(service.GetAll().Contains(record));
        }

        [Test]
        public void ShouldRemoveById()
        {
            ISleepService service = new SleepService();

            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);

            service.Add(record);

            Assert.AreEqual(1, service.GetCount());

            service.Remove(record.Id);

            Assert.AreEqual(0, service.GetCount());
            Assert.IsFalse(service.GetAll().Contains(record));
        }

        [Test]
        public void ShouldReturnLast()
        {
            ISleepService service = new SleepService();

            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));
            service.Add(new SleepRecord(date, bedtime, wakeTime));

            SleepRecord last = new SleepRecord(date, bedtime, wakeTime);
            service.Add(last);

            Assert.AreEqual(6, service.GetCount());

            Assert.AreEqual(last, service.GetLast());
        }
    }
}