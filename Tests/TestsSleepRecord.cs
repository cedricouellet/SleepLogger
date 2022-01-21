using NUnit.Framework;
using SleepLoggerLib.Models;
using System;

namespace Tests
{
    [TestFixture]
    public class TestsSleepRecord
    {
        [Test]
        public void ShouldCreate()
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Today);
            TimeOnly bedtime = TimeOnly.FromDateTime(DateTime.Today);
            TimeOnly wakeTime = TimeOnly.FromDateTime(DateTime.Now);

            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);

            Assert.AreEqual(bedtime.Hour, record.Bedtime().Hour);
            Assert.AreEqual(bedtime.Minute, record.Bedtime().Minute);

            Assert.AreEqual(wakeTime.Hour, record.WakeTime().Hour);
            Assert.AreEqual(wakeTime.Minute, record.WakeTime().Minute);

            Assert.IsNotEmpty(record.Id);
            Assert.IsNotNull(record.Id);
        }

        [Test]
        public void ShouldHaveCorrectTimeAsleep()
        {
            DateOnly date = DateOnly.FromDateTime(DateTime.Today);
            TimeOnly bedtime = TimeOnly.Parse("23:00:00");
            TimeOnly wakeTime = TimeOnly.Parse("07:00:00");

            SleepRecord record = new SleepRecord(date, bedtime, wakeTime);

            Assert.AreEqual(8, record.TimeAsleep);
        }

        [Test]
        public void ShouldEqual()
        {
            DateTime today = DateTime.Today;
            DateOnly date = DateOnly.FromDateTime(today);
            TimeOnly bedtime = TimeOnly.FromDateTime(today);
            TimeOnly wakeTime = TimeOnly.FromDateTime(today);

            SleepRecord recordA = new SleepRecord(date, bedtime, wakeTime);
            SleepRecord recordB = recordA;

            Assert.AreEqual(recordA, recordB);
            Assert.AreEqual(recordB, recordA);

            SleepRecord recordC = recordB;

            Assert.AreEqual(recordC, recordA);  
            Assert.AreEqual(recordC, recordB);
        }

        [Test]
        public void ShouldNotEqual()
        {
            DateTime today = DateTime.Today;
            DateOnly date = DateOnly.FromDateTime(today);
            TimeOnly bedtime = TimeOnly.FromDateTime(today);
            TimeOnly wakeTime = TimeOnly.FromDateTime(today);

            SleepRecord recordA = new SleepRecord(date, bedtime, wakeTime);
            SleepRecord recordB = new SleepRecord(date, bedtime, wakeTime);

            Assert.AreNotEqual(recordA.Id, recordB.Id);
            Assert.AreNotEqual(recordA, recordB);
            Assert.AreNotEqual(recordB, recordA);
        }
    }
}
