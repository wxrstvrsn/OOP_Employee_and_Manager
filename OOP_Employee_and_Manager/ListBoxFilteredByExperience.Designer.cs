namespace OOP_Employee_and_Manager
{
    partial class ListBoxFilteredByExperience
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
            ListBoxFiltered = new ListBox();
            SuspendLayout();
            // 
            // ListBoxFiltered
            // 
            ListBoxFiltered.BackColor = SystemColors.ScrollBar;
            ListBoxFiltered.Dock = DockStyle.Fill;
            ListBoxFiltered.FormattingEnabled = true;
            ListBoxFiltered.ItemHeight = 15;
            ListBoxFiltered.Location = new Point(0, 0);
            ListBoxFiltered.Name = "ListBoxFiltered";
            ListBoxFiltered.Size = new Size(1191, 611);
            ListBoxFiltered.TabIndex = 0;
            // 
            // ListBoxFilteredByExperience
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 611);
            Controls.Add(ListBoxFiltered);
            Name = "ListBoxFilteredByExperience";
            Text = "ListBoxFilteredByExperience";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxFiltered;
    }
}