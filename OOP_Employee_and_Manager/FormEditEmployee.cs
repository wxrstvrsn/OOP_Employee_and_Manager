using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Employee_and_Manager
{
    public partial class FormEditEmployee : Form
    {
        private Employee editingTarget;
        public Employee CreatedEmployee { get; private set; }
        private bool isEditMode;

        public FormEditEmployee(Employee toEdit)
        {
            InitializeComponent();
            isEditMode = true;
            editingTarget = toEdit;
            InitEditMode();
        }

        private void InitCreateMode()
        {
            comboBoxWorkerType.Visible = true;
            comboBoxWorkerType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            comboBoxWorkerType.SelectedIndex = 0;

            EnableFieldsFor("Employee");
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxWorkerType.SelectedItem.ToString();
            EnableFieldsFor(selectedType);
        }

        public FormEditEmployee()
        {
            InitializeComponent();
            isEditMode = false;
            InitCreateMode();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                DateTime hireDate = dateTimePickerHire.Value;
                float salary = float.Parse(textBoxSalary.Text);

                if (isEditMode)
                {
                    editingTarget.Name = name;
                    editingTarget.Salary = salary;
                    editingTarget.EmployDate = hireDate;

                    if (editingTarget is Manager manager)
                    {
                        manager.Bonus = float.Parse(textBoxBonus.Text);
                    }

                    if (editingTarget is HourlyManager hourly)
                    {
                        hourly.HoursWorked = int.Parse(textBoxHours.Text);
                        hourly.HourlyRate = float.Parse(textBoxRate.Text);
                    }
                }
                else
                {
                    string type = comboBoxWorkerType.SelectedItem.ToString();
                    switch (type)
                    {
                        case "Employee":
                            CreatedEmployee = new Employee(name, salary, hireDate);
                            break;
                        case "Manager":
                            float bonus = float.Parse(textBoxBonus.Text);
                            CreatedEmployee = new Manager(name, salary, hireDate, bonus);
                            break;
                        case "HourlyManager":
                            int hours = int.Parse(textBoxHours.Text);
                            float rate = float.Parse(textBoxRate.Text);
                            var hm = new HourlyManager(name, hireDate, rate);
                            hm.AddHours(hours);
                            CreatedEmployee = hm;
                            break;
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void EnableFieldsFor(string type)
        {
            textBoxBonus.Enabled = false;
            textBoxHours.Enabled = false;
            textBoxRate.Enabled = false;

            switch (type)
            {
                case "Manager":
                    textBoxBonus.Enabled = true;
                    break;
                case "HourlyManager":
                    textBoxHours.Enabled = true;
                    textBoxRate.Enabled = true;
                    break;
            }
        }

        private void InitEditMode()
        {
            comboBoxWorkerType.Visible = false; 

            textBoxName.Text = editingTarget.Name;
            textBoxSalary.Text = editingTarget.Salary.ToString();
            dateTimePickerHire.Value = editingTarget.EmployDate;
            
            EnableFieldsFor("Employee");
            
            if (editingTarget is Manager manager)
            {
                EnableFieldsFor("Manager");
                textBoxBonus.Text = manager.Bonus.ToString();
            }
            
            if (editingTarget is HourlyManager hourly)
            {
                EnableFieldsFor("HourlyManager");
                textBoxRate.Text = hourly.HourlyRate.ToString();
                textBoxHours.Text = hourly.HoursWorked.ToString();
            }
        }
    }
}