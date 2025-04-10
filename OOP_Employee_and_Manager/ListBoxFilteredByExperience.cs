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
    public partial class ListBoxFilteredByExperience : Form
    {
        public ListBoxFilteredByExperience(List<Employee> filteredEmployees)
        {
            InitializeComponent();
        }

        private void UpdateListBox(List<Employee> filteredEmployees)
        {
            foreach (var temp in filteredEmployees)
            {
                ListBoxFiltered.Items.Add(temp.ToString());
            }
        }

    }
}
