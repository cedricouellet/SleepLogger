namespace SleepLoggerForm
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStatistics.BackColor = System.Drawing.Color.Transparent;
            this.buttonStatistics.FlatAppearance.BorderSize = 2;
            this.buttonStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStatistics.Location = new System.Drawing.Point(12, 52);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(330, 49);
            this.buttonStatistics.TabIndex = 0;
            this.buttonStatistics.Text = "View Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.OnBtnStatsClick);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddRecord.FlatAppearance.BorderSize = 2;
            this.buttonAddRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonAddRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRecord.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddRecord.Location = new System.Drawing.Point(12, 111);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(330, 49);
            this.buttonAddRecord.TabIndex = 1;
            this.buttonAddRecord.Text = "Add Record";
            this.buttonAddRecord.UseVisualStyleBackColor = false;
            this.buttonAddRecord.Click += new System.EventHandler(this.OnBtnAddRecordClick);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMain.Location = new System.Drawing.Point(12, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(330, 21);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "Sleep Logger";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(12, 167);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(330, 50);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear Records";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 228);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.buttonStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Sleep Logger - Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonStatistics;
        private Button buttonAddRecord;
        private Label labelMain;
        private Button buttonClear;
    }
}