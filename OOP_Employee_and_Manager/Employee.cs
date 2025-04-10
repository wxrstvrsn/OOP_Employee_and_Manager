using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee_and_Manager
{
    internal class Employee
    {
        private string _name;
        private  float _salary;
        private DateTime _dateOfDirth;
        private DateTime _employDate;

        //C-tors
        public Employee(string name, float salary, DateTime dateOfDirth, DateTime employDate)
        {
            _name = name;
            _salary = salary;
            _dateOfDirth = dateOfDirth;
            _employDate = employDate;
        }

        /// <summary>
        /// Возвращает кол-во отработанных дней 
        /// </summary>
        private int GetExperience()
        {

            return (DateTime.Now - _employDate).Days;
        }
        /// <summary>
        /// Увеличивает зарплату на процент из param.
        /// <param name="percent"> Процент увеличения 0 - 100 </param>
        /// </summary>
        private void IncreaseSalary(float percent)
        {
            _salary += _salary * (percent / 100f);
        }


    }

}
