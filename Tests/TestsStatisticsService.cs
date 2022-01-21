using NUnit.Framework;
using SleepLoggerLib.Services;
using SleepLoggerLib.Models;
using System;

namespace Tests
{
    [TestFixture]
    public class TestsStatisticsService
    {
        [Test]
        public void AverageBedtimeShouldBeNullIfNoElements()
        {
            IStatisticsService service = new StatisticsService(new SleepService());
            TimeOnly? averageBedtime = service.GetAverageBedtime();
            Assert.IsNull(averageBedtime);
        }

        [Test]
        public void AverageWakeTimeShouldBeNullIfNoElements()
        {
            IStatisticsService service = new StatisticsService(new SleepService());
            TimeOnly? averageWakeTime = service.GetAverageWakeTime();
            Assert.IsNull(averageWakeTime);
        }

        [Test]
        public void BestRecordShouldBeNullIfNoElements()
        {
            IStatisticsService service = new StatisticsService(new SleepService());
            SleepRecord? best = service.GetBest();
            Assert.IsNull(best);
        }

        [Test]
        public void WorstRecordShouldBeNullIfNoElements()
        {
            IStatisticsService service = new StatisticsService(new SleepService());
            SleepRecord? worst = service.GetWorst();
            Assert.IsNull(worst);
        }

        [Test]
        public void AverageTimeAsleepShouldBeZeroIfNoElements()
        {
            IStatisticsService service = new StatisticsService(new SleepService());
            float averageSleepTime = service.GetAverageTimeAsleep();

            Assert.AreEqual(0, averageSleepTime);
        }

        [Test]
        public void ShouldReturnCorrectAverageTimeAsleep()
        {
            ISleepService sleepService = new SleepService();

            DateOnly date1 = DateOnly.Parse("2022-01-21");
            DateOnly date2 = DateOnly.Parse("2022-01-22");

            TimeOnly bed1 = TimeOnly.Parse("00:23:00");
            TimeOnly wake1 = TimeOnly.Parse("07:11:00");

            TimeOnly bed2 = TimeOnly.Parse("22:34:00");
            TimeOnly wake2 = TimeOnly.Parse("04:48:00");

            sleepService.Add(new SleepRecord(date1, bed1, wake1));
            sleepService.Add(new SleepRecord(date2, bed2, wake2));

            IStatisticsService service = new StatisticsService(sleepService);

            Assert.AreEqual(6f, service.GetAverageTimeAsleep());
        }

        [Test]
        public void ShouldReturnCorrectAverageBedtime()
        {
            ISleepService sleepService = new SleepService();

            DateOnly date1 = DateOnly.Parse("2022-01-21");
            DateOnly date2 = DateOnly.Parse("2022-01-22");

            TimeOnly bed1 = TimeOnly.Parse("00:15:00");
            TimeOnly wake1 = TimeOnly.Parse("07:00:00");

            TimeOnly bed2 = TimeOnly.Parse("22:54:00");
            TimeOnly wake2 = TimeOnly.Parse("04:00:00");

            sleepService.Add(new SleepRecord(date1, bed1, wake1));
            sleepService.Add(new SleepRecord(date2, bed2, wake2));

            IStatisticsService service = new StatisticsService(sleepService);

            Assert.AreEqual(11, service.GetAverageBedtime()?.Hour);
            Assert.AreEqual(34, service.GetAverageBedtime()?.Minute);
        }

        [Test]
        public void ShouldReturnCorrectAverageWakeTime()
        {
            ISleepService sleepService = new SleepService();

            DateOnly date1 = DateOnly.Parse("2022-01-21");
            DateOnly date2 = DateOnly.Parse("2022-01-22");

            TimeOnly bed1 = TimeOnly.Parse("12:00:00 AM");
            TimeOnly wake1 = TimeOnly.Parse("07:24:00 AM");

            TimeOnly bed2 = TimeOnly.Parse("10:00:00 PM");
            TimeOnly wake2 = TimeOnly.Parse("04:59:00 AM");

            sleepService.Add(new SleepRecord(date1, bed1, wake1));
            sleepService.Add(new SleepRecord(date2, bed2, wake2));

            IStatisticsService service = new StatisticsService(sleepService);

            Assert.AreEqual(6, service.GetAverageWakeTime()?.Hour);
            Assert.AreEqual(11, service.GetAverageWakeTime()?.Minute);
        }
    }
}
