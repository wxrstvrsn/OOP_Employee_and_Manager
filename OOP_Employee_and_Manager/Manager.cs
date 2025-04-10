using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Manager : Employee
{
    private float _bonus;

    public float Bonus
    {
        get => _bonus;
        set {
            if(value > Salary)
                throw new ArgumentException("Бонус не может превышать зарплату");
            _bonus = value;
        }
    }

    public Manager(string fullName, float salary, DateTime hireDate, float bonus) : base(fullName, salary, hireDate)
    {
        Bonus = bonus;
        UpdateManagerId();
    }

    private void UpdateManagerId()
    {
        Id = $"manager-{Id}";
    }

    public override float GetSalary()
    {
        return Salary + Bonus;
    }

    public override string ToString()
    {
        return $"[{Id}] {Name}, Зарплата с бонусом составит: {GetSalary()}, Стаж: {GetExperienceInDays()} дн.";
    }
}

