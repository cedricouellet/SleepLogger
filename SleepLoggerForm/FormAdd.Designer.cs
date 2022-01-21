namespace SleepLoggerForm
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelBedtime = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBedtime = new System.Windows.Forms.DateTimePicker();
            this.labelWakeTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerWakeTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdd
            // 
            this.labelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelAdd.Location = new System.Drawing.Point(12, 9);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(288, 21);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add a Sleep Record";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelBedtime
            // 
            this.labelBedtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBedtime.AutoSize = true;
            this.labelBedtime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBedtime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelBedtime.Location = new System.Drawing.Point(12, 109);
            this.labelBedtime.Name = "labelBedtime";
            this.labelBedtime.Size = new System.Drawing.Size(58, 15);
            this.labelBedtime.TabIndex = 2;
            this.labelBedtime.Text = "Bedtime:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 68);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(288, 23);
            this.dateTimePickerDate.TabIndex = 4;
            this.dateTimePickerDate.Value = new System.DateTime(2022, 1, 21, 15, 44, 57, 0);
            // 
            // dateTimePickerBedtime
            // 
            this.dateTimePickerBedtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBedtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBedtime.Location = new System.Drawing.Point(12, 127);
            this.dateTimePickerBedtime.Name = "dateTimePickerBedtime";
            this.dateTimePickerBedtime.Size = new System.Drawing.Size(288, 23);
            this.dateTimePickerBedtime.TabIndex = 5;
            this.dateTimePickerBedtime.Value = new System.DateTime(2022, 1, 21, 23, 0, 0, 0);
            // 
            // labelWakeTime
            // 
            this.labelWakeTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWakeTime.AutoSize = true;
            this.labelWakeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWakeTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelWakeTime.Location = new System.Drawing.Point(12, 169);
            this.labelWakeTime.Name = "labelWakeTime";
            this.labelWakeTime.Size = new System.Drawing.Size(71, 15);
            this.labelWakeTime.TabIndex = 3;
            this.labelWakeTime.Text = "Wake time:";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDate.Location = new System.Drawing.Point(12, 50);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 15);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Date:";
            // 
            // dateTimePickerWakeTime
            // 
            this.dateTimePickerWakeTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerWakeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWakeTime.Location = new System.Drawing.Point(12, 187);
            this.dateTimePickerWakeTime.Name = "dateTimePickerWakeTime";
            this.dateTimePickerWakeTime.Size = new System.Drawing.Size(288, 23);
            this.dateTimePickerWakeTime.TabIndex = 6;
            this.dateTimePickerWakeTime.Value = new System.DateTime(2022, 1, 21, 7, 0, 0, 0);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAdd.Location = new System.Drawing.Point(12, 238);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(288, 50);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.OnClickButtonAdd);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(313, 299);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.dateTimePickerWakeTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelWakeTime);
            this.Controls.Add(this.labelBedtime);
            this.Controls.Add(this.dateTimePickerBedtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Sleep Logger - Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAdd;
        private Label labelBedtime;
        private DateTimePicker dateTimePickerDate;
        private DateTimePicker dateTimePickerBedtime;
        private Label labelWakeTime;
        private Label labelDate;
        private DateTimePicker dateTimePickerWakeTime;
        private Button buttonAdd;
    }
}