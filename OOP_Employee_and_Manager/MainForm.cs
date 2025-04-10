using System.Diagnostics;
using OOP_Employee_and_Manager;

namespace OOP_Employee_and_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            if (listBoxAllEmployees.SelectedIndex == -1) return;

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
    }
}