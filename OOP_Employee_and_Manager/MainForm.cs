#define DEMO
using System.Diagnostics;
using OOP_Employee_and_Manager;

namespace OOP_Employee_and_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        #if DEMO
            SeedData();
        #endif
        }

        private List<Employee> allEmployees = new List<Employee>();

        private void increaseSalary_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxPercent.Text, out float percent) || percent == 0)
            {
                MessageBox.Show("Введите корректный процент!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (checkBoxIncrease4All.Checked == false)
            {
                if (listBoxAllEmployees.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                allEmployees[listBoxAllEmployees.SelectedIndex].IncreaseSalary(percent);
                Console.WriteLine("|-----------Increased 4 selected-----------|");
            }
            else
            {
                foreach (var temp in allEmployees)
                {
                    temp.IncreaseSalary(percent);
                }

                Console.WriteLine("|-----------Increased 4 all-----------|");
            }

            RefreshAllEmployeesList();
        }

        private void RefreshAllEmployeesList()
        {
            listBoxAllEmployees.Items.Clear();

            foreach (var emp in allEmployees)
            {
                listBoxAllEmployees.Items.Add(emp.ToString());
            }

            Console.WriteLine("|-----------Refreshed-----------|");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxAllEmployees.SelectedIndex >= 0)
            {
                /*MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;*/

                var selected = allEmployees[listBoxAllEmployees.SelectedIndex];

                FormEditEmployee editor = new FormEditEmployee(selected);
                Console.WriteLine("|-----------FormEditEmployee requsted 4 update-----------|");

                if (editor.ShowDialog() == DialogResult.OK)
                {
                    RefreshAllEmployeesList();
                }
            }
            else
            {
                Console.WriteLine("|-----------FormEditEmployee requsted 4 create-----------|");
                var form = new FormEditEmployee();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    allEmployees.Add(form.CreatedEmployee);
                    RefreshAllEmployeesList();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxAllEmployees.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите работника из списка", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            allEmployees.RemoveAt(listBoxAllEmployees.SelectedIndex);
            RefreshAllEmployeesList();
            Console.WriteLine("|-----------Entity deleted-----------|");
        }

        private List<Employee> filteredEmployees(int reqDaysLimit)
        {
            List<Employee> temp = new List<Employee>();

            foreach (var _ in allEmployees)
            {
                if (_.GetExperienceInDays() >= reqDaysLimit)
                {
                    Console.WriteLine("|-----------Filter workin, adding entities-----------|");
                    temp.Add(_);
                }
            }

            return temp;
        }

        private void requestFiltered_Click(object sender, EventArgs e)
        {
            Console.WriteLine("|-----------ListBoxFilteredByExperience requested");
            if (!int.TryParse(textReqExp.Text, out int reqDays))
            {
                MessageBox.Show("Введите корректное кол-во дней для фильтра!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            List<Employee> filtered = filteredEmployees(reqDays);
            var formFiltered = new ListBoxFilteredByExperience(filtered);
            formFiltered.ShowDialog();
        }

        private void SeedData()
        {
            var random = new Random();

            string[] firstNames = { "Иван", "Пётр", "Алексей", "Дмитрий", "Максим", "Сергей", "Андрей", "Константин" };
            string[] lastNames =
                { "Иванов", "Петров", "Сидоров", "Кузнецов", "Мельников", "Смирнов", "Орлов", "Волков" };
            string[] patronymics = { "Иванович", "Петрович", "Алексеевич", "Дмитриевич", "Максимович" };

            // Генерация обычных сотрудников
            for (int i = 0; i < 5; i++)
            {
                string fullName =
                    $"{lastNames[random.Next(lastNames.Length)]} {firstNames[random.Next(firstNames.Length)]} {patronymics[random.Next(patronymics.Length)]}";
                float salary = random.Next(35000, 50000);
                DateTime hireDate = DateTime.Now.AddDays(-random.Next(300, 1500));

                var emp = new Employee(fullName, salary, hireDate);
                allEmployees.Add(emp);
            }

            // Генерация менеджеров
            for (int i = 0; i < 3; i++)
            {
                string fullName =
                    $"{lastNames[random.Next(lastNames.Length)]} {firstNames[random.Next(firstNames.Length)]} {patronymics[random.Next(patronymics.Length)]}";
                float salary = random.Next(55000, 70000);
                float bonus = random.Next(3000, 10000);
                DateTime hireDate = DateTime.Now.AddDays(-random.Next(500, 2000));

                var manager = new Manager(fullName, salary, hireDate, bonus);
                allEmployees.Add(manager);
            }

            for (int i = 0; i < 3; i++)
            {
                string fullName =
                    $"{lastNames[random.Next(lastNames.Length)]} {firstNames[random.Next(firstNames.Length)]} {patronymics[random.Next(patronymics.Length)]}";
                DateTime hireDate = DateTime.Now.AddDays(-random.Next(100, 600));
                float rate = random.Next(500, 1000);
                int hours = random.Next(10, 60);

                var hourly = new HourlyManager(fullName, hireDate, rate);
                hourly.AddHours(hours);

                allEmployees.Add(hourly);
            }

            RefreshAllEmployeesList();
        }
    }
}