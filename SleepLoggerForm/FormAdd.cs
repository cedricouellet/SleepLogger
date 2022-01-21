using SleepLoggerLib;

namespace SleepLoggerForm
{
    public partial class FormAdd : Form
    {
        private readonly ISleepManager _sleepManager;

        public static event Action? OnRecordAdded;

        public FormAdd(ISleepManager sleepManager)
        {
            _sleepManager = sleepManager;

            InitializeComponent();
        }

        private void OnClickButtonAdd(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.FromDateTime(dateTimePickerDate.Value);
            TimeOnly bedtime = TimeOnly.FromDateTime(dateTimePickerBedtime.Value);
            TimeOnly wakeTime = TimeOnly.FromDateTime(dateTimePickerWakeTime.Value);

            _sleepManager.AddRecord(date, bedtime, wakeTime);
            OnRecordAdded?.Invoke();
            Close();
        }
    }
}
