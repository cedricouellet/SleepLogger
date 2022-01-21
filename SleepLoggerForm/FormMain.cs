using SleepLoggerLib;
using System.Text;

namespace SleepLoggerForm
{
    public partial class FormMain : Form
    {
        private FormAdd? _formAdd = null;
        private FormStatistics? _formStats = null;

        private readonly ISleepManager _sleepManager;

        public FormMain()
        {
            InitializeComponent();

            _sleepManager = SleepManager.Instance;

            StartPosition = FormStartPosition.CenterScreen;

            FormClosing += OnFormClosing;
            buttonAddRecord.Click += OnBtnAddRecordClick;
            buttonStatistics.Click += OnBtnStatsClick;
            buttonClear.Click += OnBtnClearClick;

            FormAdd.OnRecordAdded += UpdateBtnClearEnabled;
        
            UpdateBtnClearEnabled();
        }

        private void UpdateBtnClearEnabled()
        {
            buttonClear.Enabled = _sleepManager.CountRecords() > 0;
        }

        private void OnBtnClearClick(object? sender, EventArgs e)
        {
            int recordCount = _sleepManager.CountRecords();

            if (recordCount > 0)
            {
                string text = new StringBuilder()
                    .AppendLine("Are you sure you want to clear all sleep records?")
                    .AppendLine()
                    .AppendLine($"If you choose to do this, {recordCount} sleep record(s) will be lost permanently.")
                    .ToString();

                string caption = "Confirmation - Record Deletion";

                DialogResult confirmationResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (confirmationResult == DialogResult.Yes)
                {
                    _sleepManager.RemoveAllRecords();
                    buttonClear.Enabled = false;
                }
            }
        }

        private void OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            _sleepManager.Save();
        }

        private void OnBtnAddRecordClick(object? sender, EventArgs e)
        {
            if (_formAdd == null)
            {
                _formAdd = new FormAdd(_sleepManager);
                _formAdd.StartPosition = FormStartPosition.CenterScreen;
                _formAdd.FormClosing += OnAddFormClosing;
            }
           
            _formAdd.Show();

            Hide();
        }

        private void OnBtnStatsClick(object? sender, EventArgs e)
        {
            if (_formStats == null)
            {
                _formStats = new FormStatistics(_sleepManager);
                _formStats.StartPosition = FormStartPosition.CenterScreen;
                _formStats.FormClosing += OnStatsFormClosing;
            }
          
            _formStats.Show();
            Hide();
        }

        private void OnAddFormClosing(object? sender, FormClosingEventArgs e)
        {
            _formAdd?.Dispose();
            _formAdd = null;
            Show();
        }

        private void OnStatsFormClosing(object? sender, FormClosingEventArgs e)
        {
            _formStats?.Dispose();
            _formStats = null;
            Show();
        }
    }
}