using OOP_Employee_and_Manager;

namespace OOP_Employee_and_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Employee> allEmployees = new List<Employee>();

        private void createEmp_Click(object sender, EventArgs e)
        {
            var emp = new Employee("Иванов И.И.", 1000, new DateTime(2010, 1, 1));
            allEmployees.Add(emp);

            RefreshAllEmployeesList();
        }

        private void increaseSalary_Click(object sender, EventArgs e)
        {
            if (listBoxAllEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textBoxPercent.Text, out float percent) || percent == 0)
            {
                MessageBox.Show("Введите корректный процент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            allEmployees[listBoxAllEmployees.SelectedIndex].IncreaseSalary(percent);
            RefreshAllEmployeesList();
        }

        private void RefreshAllEmployeesList()
        {
            listBoxAllEmployees.Items.Clear();

            foreach (var emp in allEmployees)
            {
                listBoxAllEmployees.Items.Add(emp.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void createManager_Click(object sender, EventArgs e)
        {
            var manager = new Manager("Иванов И.И.", 1000, new DateTime(2010, 1, 1), 10);
            allEmployees.Add(manager);

            RefreshAllEmployeesList();
        }

        private void createHourly_Click(object sender, EventArgs e)
        {
            var hourly = new HourlyManager("Петров Сергей", new DateTime(2023, 1, 10), 700);
            hourly.AddHours(10);
            allEmployees.Add(hourly);
            RefreshAllEmployeesList();
        }

        private void buttonUpdate_Click(object? sender, EventArgs e)
        {
            if(listBoxAllEmployees.SelectedIndex == -1) {
                MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selected = allEmployees[listBoxAllEmployees.SelectedIndex];

            FormEditEmployee editor = new FormEditEmployee(selected);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                RefreshAllEmployeesList();
            }
        }
    }
}