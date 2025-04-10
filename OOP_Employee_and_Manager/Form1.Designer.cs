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
            listBoxWorkers = new ListBox();
            SuspendLayout();
            // 
            // createEmp
            // 
            createEmp.Location = new Point(37, 92);
            createEmp.Name = "createEmp";
            createEmp.Size = new Size(72, 56);
            createEmp.TabIndex = 0;
            createEmp.Text = "Create\r\nPerson";
            createEmp.UseVisualStyleBackColor = true;
            // 
            // listBoxWorkers
            // 
            listBoxWorkers.FormattingEnabled = true;
            listBoxWorkers.ItemHeight = 15;
            listBoxWorkers.Location = new Point(524, 165);
            listBoxWorkers.Name = "listBoxWorkers";
            listBoxWorkers.Size = new Size(436, 229);
            listBoxWorkers.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 656);
            Controls.Add(listBoxWorkers);
            Controls.Add(createEmp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button createEmp;
        private ListBox listBoxWorkers;
    }
}
