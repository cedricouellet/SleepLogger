using SleepLoggerLib;
using SleepLoggerLib.Models;
using System.Text;

namespace SleepLoggerForm
{
    public partial class FormStatistics : Form
    {
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
            labelValueBestRecord.Text = _sleepManager.GetBestRecord()?.ToString() ?? "Best record not set.";
            labelValueWorstRecord.Text = _sleepManager.GetWorstRecord()?.ToString() ?? "Worst record not set.";
            labelValueLastRecord.Text = _sleepManager.GetLastRecord()?.ToString() ?? "No records set.";
        }

        private void DisplaySleepRecords()
        {
            StringBuilder recordsSb = new StringBuilder();
            foreach (SleepRecord record in _sleepManager.GetAllRecords().OrderByDescending(rec => rec.Date()))
            {
                recordsSb.AppendLine($"• {record}");
            }

            richTextBoxSleepRecords.Text = recordsSb.ToString();
        }
    }
}
