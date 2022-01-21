using SleepLoggerLib;
using SleepLoggerLib.Models;
using System.Text;

namespace SleepLoggerForm
{
    public partial class FormStatistics : Form
    {
        private const string NotAvailable = "N/A";

        private readonly ISleepManager _sleepManager;

        public FormStatistics(ISleepManager sleepManager)
        {
            _sleepManager = sleepManager;
            InitializeComponent();

            DisplaySleepRecords();
            DisplayStatistics();
        }

        private void DisplayStatistics()
        {
            labelValueBestRecord.Text = _sleepManager.GetBestRecord()?.ToString() ?? NotAvailable;
            labelValueWorstRecord.Text = _sleepManager.GetWorstRecord()?.ToString() ?? NotAvailable;
            labelValueLastRecord.Text = _sleepManager.GetLastRecord()?.ToString() ?? NotAvailable;

            float averageTimeAsleep = _sleepManager.GetAverageTimeAsleep();
            labelValueAverageTimeAsleep.Text = averageTimeAsleep > 0 ? $"{averageTimeAsleep:0.#} hours" : NotAvailable;

            Tuple<int, int>? averageBedtime = _sleepManager.GetAverageBedtime();
            labelValueAverageBedtime.Text = averageBedtime != null ? $"{averageBedtime.Item1} hours {averageBedtime.Item2} minutes" : NotAvailable;

            Tuple<int, int>? averageWakeTime = _sleepManager.GetAverageWakeTime();
            labelValueAverageWakeTime.Text = averageWakeTime != null ? $"{averageWakeTime.Item1} hours {averageWakeTime.Item2} minutes" : NotAvailable;
        }

        private void DisplaySleepRecords()
        {
            StringBuilder recordsSb = new StringBuilder();

            if (_sleepManager.CountRecords() == 0)
            {
                recordsSb.AppendLine("No records set.")
                    .AppendLine()
                    .AppendLine("Add records to start viewing statistics.");
            } 
            else
            {
                foreach (SleepRecord record in _sleepManager.GetAllRecords().OrderByDescending(rec => rec.Date()))
                {
                    recordsSb.AppendLine(record.ToString());
                }
            }

            richTextBoxSleepRecords.Text = recordsSb.ToString();
        }
    }
}
