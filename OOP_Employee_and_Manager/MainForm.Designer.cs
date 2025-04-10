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
            SuspendLayout();
            // 
            // listBoxAllEmployees
            // 
            listBoxAllEmployees.FormattingEnabled = true;
            listBoxAllEmployees.ItemHeight = 15;
            listBoxAllEmployees.Location = new Point(413, 65);
            listBoxAllEmployees.Name = "listBoxAllEmployees";
            listBoxAllEmployees.Size = new Size(531, 229);
            listBoxAllEmployees.TabIndex = 1;
            // 
            // increaseSalary
            // 
            increaseSalary.Location = new Point(872, 311);
            increaseSalary.Name = "increaseSalary";
            increaseSalary.Size = new Size(72, 56);
            increaseSalary.TabIndex = 2;
            increaseSalary.Text = "Increase\r\nSalary";
            increaseSalary.UseVisualStyleBackColor = true;
            increaseSalary.Click += increaseSalary_Click;
            // 
            // textBoxPercent
            // 
            textBoxPercent.Location = new Point(766, 329);
            textBoxPercent.Name = "textBoxPercent";
            textBoxPercent.PlaceholderText = "percent";
            textBoxPercent.Size = new Size(100, 23);
            textBoxPercent.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(627, 37);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "Employees";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(413, 300);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(165, 151);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update \r\nCreate\r\n";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(841, 373);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(103, 89);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 656);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Controls.Add(textBoxPercent);
            Controls.Add(increaseSalary);
            Controls.Add(listBoxAllEmployees);
            Name = "MainForm";
            Text = "Form1";
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
    }
}
