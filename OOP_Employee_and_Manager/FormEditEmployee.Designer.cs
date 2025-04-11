namespace OOP_Employee_and_Manager
{
    partial class FormEditEmployee
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
            textBoxName = new TextBox();
            textBoxSalary = new TextBox();
            dateTimePickerHire = new DateTimePicker();
            textBoxBonus = new TextBox();
            textBoxHours = new TextBox();
            textBoxRate = new TextBox();
            buttonSave = new Button();
            comboBoxWorkerType = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ScrollBar;
            textBoxName.Font = new Font("Verdana", 14.25F);
            textBoxName.Location = new Point(632, 187);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Name";
            textBoxName.Size = new Size(100, 31);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSalary
            // 
            textBoxSalary.BackColor = SystemColors.ScrollBar;
            textBoxSalary.Font = new Font("Verdana", 14.25F);
            textBoxSalary.Location = new Point(632, 216);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.PlaceholderText = "Salary";
            textBoxSalary.Size = new Size(100, 31);
            textBoxSalary.TabIndex = 1;
            // 
            // dateTimePickerHire
            // 
            dateTimePickerHire.CalendarMonthBackground = SystemColors.ScrollBar;
            dateTimePickerHire.Font = new Font("Verdana", 14.25F);
            dateTimePickerHire.Location = new Point(632, 245);
            dateTimePickerHire.Name = "dateTimePickerHire";
            dateTimePickerHire.Size = new Size(200, 31);
            dateTimePickerHire.TabIndex = 2;
            // 
            // textBoxBonus
            // 
            textBoxBonus.BackColor = SystemColors.ScrollBar;
            textBoxBonus.Font = new Font("Verdana", 14.25F);
            textBoxBonus.Location = new Point(632, 274);
            textBoxBonus.Name = "textBoxBonus";
            textBoxBonus.PlaceholderText = "Bonus";
            textBoxBonus.Size = new Size(100, 31);
            textBoxBonus.TabIndex = 3;
            // 
            // textBoxHours
            // 
            textBoxHours.BackColor = SystemColors.ScrollBar;
            textBoxHours.Font = new Font("Verdana", 14.25F);
            textBoxHours.Location = new Point(632, 303);
            textBoxHours.Name = "textBoxHours";
            textBoxHours.PlaceholderText = "Hours";
            textBoxHours.Size = new Size(100, 31);
            textBoxHours.TabIndex = 4;
            // 
            // textBoxRate
            // 
            textBoxRate.BackColor = SystemColors.ScrollBar;
            textBoxRate.Font = new Font("Verdana", 14.25F);
            textBoxRate.Location = new Point(632, 332);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.PlaceholderText = "Rate";
            textBoxRate.Size = new Size(100, 31);
            textBoxRate.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ScrollBar;
            buttonSave.Font = new Font("Verdana", 14.25F);
            buttonSave.Location = new Point(632, 394);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 108);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save\r\nChanges";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // comboBoxWorkerType
            // 
            comboBoxWorkerType.BackColor = SystemColors.ScrollBar;
            comboBoxWorkerType.Font = new Font("Verdana", 14.25F);
            comboBoxWorkerType.FormattingEnabled = true;
            comboBoxWorkerType.Items.AddRange(new object[] { "Employee", "Manager", "HourlyManager" });
            comboBoxWorkerType.Location = new Point(632, 110);
            comboBoxWorkerType.Name = "comboBoxWorkerType";
            comboBoxWorkerType.Size = new Size(121, 31);
            comboBoxWorkerType.TabIndex = 7;
            // 
            // FormEditEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 665);
            Controls.Add(comboBoxWorkerType);
            Controls.Add(buttonSave);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxHours);
            Controls.Add(textBoxBonus);
            Controls.Add(dateTimePickerHire);
            Controls.Add(textBoxSalary);
            Controls.Add(textBoxName);
            Name = "FormEditEmployee";
            Text = "FormEditEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSalary;
        private DateTimePicker dateTimePickerHire;
        private TextBox textBoxBonus;
        private TextBox textBoxHours;
        private TextBox textBoxRate;
        private Button buttonSave;
        private ComboBox comboBoxWorkerType;
    }
}