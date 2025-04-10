namespace OOP_Employee_and_Manager
{
    partial class Form1
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
            createEmp = new Button();
            listBoxEmployees = new ListBox();
            increaseSalary = new Button();
            textBoxPercent = new TextBox();
            label1 = new Label();
            labelManagers = new Label();
            listBoxManagers = new ListBox();
            createManager = new Button();
            label2 = new Label();
            listBoxHourlyManagers = new ListBox();
            createHourlyManager = new Button();
            buttonUpdate = new Button();
            SuspendLayout();
            // 
            // createEmp
            // 
            createEmp.Location = new Point(52, 294);
            createEmp.Name = "createEmp";
            createEmp.Size = new Size(72, 56);
            createEmp.TabIndex = 0;
            createEmp.Text = "Create\r\nEmployee\r\n";
            createEmp.UseVisualStyleBackColor = true;
            createEmp.Click += createEmp_Click;
            // 
            // listBoxEmployees
            // 
            listBoxEmployees.FormattingEnabled = true;
            listBoxEmployees.ItemHeight = 15;
            listBoxEmployees.Location = new Point(52, 59);
            listBoxEmployees.Name = "listBoxEmployees";
            listBoxEmployees.Size = new Size(531, 229);
            listBoxEmployees.TabIndex = 1;
            // 
            // increaseSalary
            // 
            increaseSalary.Location = new Point(566, 385);
            increaseSalary.Name = "increaseSalary";
            increaseSalary.Size = new Size(72, 56);
            increaseSalary.TabIndex = 2;
            increaseSalary.Text = "Increase\r\nSalary";
            increaseSalary.UseVisualStyleBackColor = true;
            increaseSalary.Click += increaseSalary_Click;
            // 
            // textBoxPercent
            // 
            textBoxPercent.Location = new Point(644, 403);
            textBoxPercent.Name = "textBoxPercent";
            textBoxPercent.Size = new Size(100, 23);
            textBoxPercent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(266, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "Employees";
            // 
            // labelManagers
            // 
            labelManagers.AutoSize = true;
            labelManagers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelManagers.Location = new Point(899, 31);
            labelManagers.Name = "labelManagers";
            labelManagers.Size = new Size(96, 25);
            labelManagers.TabIndex = 6;
            labelManagers.Text = "Managers";
            // 
            // listBoxManagers
            // 
            listBoxManagers.FormattingEnabled = true;
            listBoxManagers.ItemHeight = 15;
            listBoxManagers.Location = new Point(682, 59);
            listBoxManagers.Name = "listBoxManagers";
            listBoxManagers.Size = new Size(531, 229);
            listBoxManagers.TabIndex = 5;
            // 
            // createManager
            // 
            createManager.Location = new Point(1139, 294);
            createManager.Name = "createManager";
            createManager.Size = new Size(72, 56);
            createManager.TabIndex = 7;
            createManager.Text = "Create\r\nManager\r\n";
            createManager.UseVisualStyleBackColor = true;
            createManager.Click += createManager_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(216, 375);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 9;
            label2.Text = "Hourly Managers";
            // 
            // listBoxHourlyManagers
            // 
            listBoxHourlyManagers.FormattingEnabled = true;
            listBoxHourlyManagers.ItemHeight = 15;
            listBoxHourlyManagers.Location = new Point(29, 403);
            listBoxHourlyManagers.Name = "listBoxHourlyManagers";
            listBoxHourlyManagers.Size = new Size(531, 229);
            listBoxHourlyManagers.TabIndex = 8;
            // 
            // createHourlyManager
            // 
            createHourlyManager.Location = new Point(566, 576);
            createHourlyManager.Name = "createHourlyManager";
            createHourlyManager.Size = new Size(72, 56);
            createHourlyManager.TabIndex = 10;
            createHourlyManager.Text = "Create Hourly\r\nManager\r\n";
            createHourlyManager.UseVisualStyleBackColor = true;
            createHourlyManager.Click += createHourly_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(775, 365);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(296, 225);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update\r\nInformation";
            buttonUpdate.UseVisualStyleBackColor = true;
            /*buttonUpdate.Click += buttonUpdate_Click;*/
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 656);
            Controls.Add(buttonUpdate);
            Controls.Add(createHourlyManager);
            Controls.Add(label2);
            Controls.Add(listBoxHourlyManagers);
            Controls.Add(createManager);
            Controls.Add(labelManagers);
            Controls.Add(listBoxManagers);
            Controls.Add(label1);
            Controls.Add(textBoxPercent);
            Controls.Add(increaseSalary);
            Controls.Add(listBoxEmployees);
            Controls.Add(createEmp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createEmp;
        private ListBox listBoxEmployees;
        private Button increaseSalary;
        private TextBox textBoxPercent;
        private Label label1;
        private Label labelManagers;
        private ListBox listBoxManagers;
        private Button createManager;
        private Label label2;
        private ListBox listBoxHourlyManagers;
        private Button createHourlyManager;
        private Button buttonUpdate;
    }
}
