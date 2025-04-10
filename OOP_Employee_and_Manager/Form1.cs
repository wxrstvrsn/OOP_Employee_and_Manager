using OOP_Employee_and_Manager;

namespace OOP_Employee_and_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Employee> employees = new List<Employee>();
        private List<Manager> managers = new List<Manager>();
        private List<HourlyManager> hourlyManagers = new List<HourlyManager>();

        private void createEmp_Click(object sender, EventArgs e)
        {
            var emp = new Employee("Иванов И.И.", 1000, new DateTime(2010, 1, 1));
            employees.Add(emp);

            RefreshEmployeeList();
        }

        private void increaseSalary_Click(object sender, EventArgs e)
        {
            if (listBoxEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(textBoxPercent.Text, out float percent) || percent == 0)
            {
                MessageBox.Show("Введите корректный процент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employees[listBoxEmployees.SelectedIndex].IncreaseSalary(percent);
            RefreshEmployeeList();
        }

        private void RefreshEmployeeList()
        {
            listBoxEmployees.Items.Clear();
            foreach (var emp in employees)
                listBoxEmployees.Items.Add(emp.ToString());
        }
        
        private void RefreshManagerList()
        {
            listBoxManagers.Items.Clear();
            foreach (var emp in managers)
                listBoxManagers.Items.Add(emp.ToString());
        }
        
        private void RefreshHourlyList()
        {
            listBoxHourlyManagers.Items.Clear();
            foreach (var emp in hourlyManagers)
                listBoxHourlyManagers.Items.Add(emp.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void createManager_Click(object sender, EventArgs e)
        {
            var manager = new Manager("Иванов И.И.", 1000, new DateTime(2010, 1, 1), 10);
            managers.Add(manager);

            RefreshManagerList();
        }

        private void createHourly_Click(object sender, EventArgs e)
        {
            var hourly = new HourlyManager("Петров Сергей", new DateTime(2023, 1, 10), 700);
            hourly.AddHours(10);
            hourlyManagers.Add(hourly);
            RefreshHourlyList();
        }

        /*private void buttonUpdate_Click(object? sender, EventArgs e)
        {
            if(listBoxEmployees == -1) 
        }*/
    }
}