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
        private Employee _employee;

        public FormEditEmployee(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            InitForm();
        }

        private void InitForm()
        {
            textBoxName.Text = _employee.Name;
            textBoxSalary.Text = _employee.Salary.ToString();
            dateTimePickerHire.Value = _employee.EmployDate;

            if (_employee is Manager manager)
            {
                textBoxBonus.Enabled = true;
                textBoxBonus.Text = manager.Bonus.ToString();
            }
            else
            {
                textBoxBonus.Enabled = true;
                textBoxBonus.Text = "";
            }

            if (_employee is HourlyManager hourlyManager)
            {
                textBoxBonus.Enabled = true;
                textBoxRate.Enabled = true;
                textBoxHours.Text = hourlyManager.HoursWorked.ToString();
                textBoxRate.Text = hourlyManager.HourlyRate.ToString();
            }
            else
            {
                textBoxHours.Enabled = false;
                textBoxHours.Text = "";

                textBoxRate.Enabled = false;
                textBoxRate.Text = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _employee.Name = textBoxName.Text;
                _employee.Salary = float.Parse(textBoxSalary.Text);
                _employee.EmployDate = dateTimePickerHire.Value;

                if (_employee is Manager manager)
                {
                    manager.Bonus = float.Parse(textBoxBonus.Text);
                }

                if (_employee is HourlyManager hourly)
                {
                    hourly.HoursWorked = int.Parse(textBoxHours.Text);
                    hourly.HourlyRate = float.Parse(textBoxRate.Text);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}