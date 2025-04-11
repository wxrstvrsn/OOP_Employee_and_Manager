namespace OOP_Employee_and_Manager
{
    partial class MainForm
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
            listBoxAllEmployees = new ListBox();
            increaseSalary = new Button();
            textBoxPercent = new TextBox();
            label1 = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            requestFiltered = new Button();
            textReqExp = new TextBox();
            checkBoxIncrease4All = new CheckBox();
            SuspendLayout();
            // 
            // listBoxAllEmployees
            // 
            listBoxAllEmployees.BackColor = SystemColors.ActiveBorder;
            listBoxAllEmployees.BorderStyle = BorderStyle.None;
            listBoxAllEmployees.Dock = DockStyle.Top;
            listBoxAllEmployees.Font = new Font("Verdana", 14.25F);
            listBoxAllEmployees.ForeColor = SystemColors.WindowText;
            listBoxAllEmployees.FormattingEnabled = true;
            listBoxAllEmployees.ItemHeight = 23;
            listBoxAllEmployees.Location = new Point(0, 0);
            listBoxAllEmployees.Margin = new Padding(10);
            listBoxAllEmployees.Name = "listBoxAllEmployees";
            listBoxAllEmployees.Size = new Size(1271, 161);
            listBoxAllEmployees.TabIndex = 1;
            // 
            // increaseSalary
            // 
            increaseSalary.AutoSize = true;
            increaseSalary.BackColor = SystemColors.ActiveBorder;
            increaseSalary.Font = new Font("Verdana", 14.25F);
            increaseSalary.Location = new Point(1159, 405);
            increaseSalary.Name = "increaseSalary";
            increaseSalary.Size = new Size(101, 56);
            increaseSalary.TabIndex = 2;
            increaseSalary.Text = "Increase\r\nSalary";
            increaseSalary.UseVisualStyleBackColor = false;
            increaseSalary.Click += increaseSalary_Click;
            // 
            // textBoxPercent
            // 
            textBoxPercent.BackColor = SystemColors.ActiveBorder;
            textBoxPercent.Font = new Font("Verdana", 14.25F);
            textBoxPercent.Location = new Point(1053, 430);
            textBoxPercent.Name = "textBoxPercent";
            textBoxPercent.PlaceholderText = "percent";
            textBoxPercent.Size = new Size(100, 31);
            textBoxPercent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 14.25F);
            label1.Location = new Point(0, 161);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 4;
            label1.Text = "Employees";
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ActiveBorder;
            buttonUpdate.Font = new Font("Verdana", 14.25F);
            buttonUpdate.Location = new Point(1159, 217);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(103, 89);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update \r\nCreate\r\n";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ActiveBorder;
            buttonDelete.Font = new Font("Verdana", 14.25F);
            buttonDelete.Location = new Point(1159, 310);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 89);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // requestFiltered
            // 
            requestFiltered.BackColor = SystemColors.ActiveBorder;
            requestFiltered.Font = new Font("Verdana", 14.25F);
            requestFiltered.Location = new Point(17, 303);
            requestFiltered.Name = "requestFiltered";
            requestFiltered.Size = new Size(93, 77);
            requestFiltered.TabIndex = 14;
            requestFiltered.Text = "request\r\nFiltered";
            requestFiltered.UseVisualStyleBackColor = false;
            requestFiltered.Click += requestFiltered_Click;
            // 
            // textReqExp
            // 
            textReqExp.BackColor = SystemColors.ActiveBorder;
            textReqExp.Font = new Font("Verdana", 14.25F);
            textReqExp.Location = new Point(116, 340);
            textReqExp.Name = "textReqExp";
            textReqExp.PlaceholderText = "textReqExp";
            textReqExp.Size = new Size(131, 31);
            textReqExp.TabIndex = 15;
            // 
            // checkBoxIncrease4All
            // 
            checkBoxIncrease4All.AutoSize = true;
            checkBoxIncrease4All.BackColor = SystemColors.ActiveBorder;
            checkBoxIncrease4All.Font = new Font("Verdana", 14.25F);
            checkBoxIncrease4All.Location = new Point(1022, 468);
            checkBoxIncrease4All.Name = "checkBoxIncrease4All";
            checkBoxIncrease4All.Size = new Size(237, 27);
            checkBoxIncrease4All.TabIndex = 16;
            checkBoxIncrease4All.Text = "checkBoxIncrease4All";
            checkBoxIncrease4All.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 656);
            Controls.Add(checkBoxIncrease4All);
            Controls.Add(textReqExp);
            Controls.Add(requestFiltered);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Controls.Add(textBoxPercent);
            Controls.Add(increaseSalary);
            Controls.Add(listBoxAllEmployees);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxAllEmployees;
        private Button increaseSalary;
        private TextBox textBoxPercent;
        private Label label1;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button requestFiltered;
        private TextBox textReqExp;
        private CheckBox checkBoxIncrease4All;
    }
}
