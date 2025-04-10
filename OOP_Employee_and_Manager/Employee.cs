using System;

public class Employee
{
    private static int _counter = 1;

    public string Name { get; set; }
    public float Salary { get; set; }
    public DateTime EmployDate { get; set; }
    public DateTime DateOfBirth { get; set; }
    protected string Id { get; set; }

    public Employee(string fullName, float salary, DateTime hireDate)
    {
        Name = fullName;
        Salary = salary;
        EmployDate = hireDate;
        DateOfBirth = DateTime.MinValue; 
        GenerateId();
    }

    public Employee(string fullName, DateTime hireDate)
        : this(fullName, 0, hireDate)
    {
    }

    private void GenerateId()
    {
        var lastNameInitial = Name.Split(' ')[0][0];
        Id = $"{char.ToUpper(lastNameInitial)}{_counter++:D3}";
    }

    public void IncreaseSalary(float percent)
    {
        Salary += Salary * (percent / 100f);
    }

    public int GetExperienceInDays()
    {
        return (DateTime.Now - EmployDate).Days;
    }

    public virtual float GetSalary()
    {
        return Salary;
    }

    public override string ToString()
    {
        return $"Employee: [{Id}] {Name}, Зарплата: {GetSalary():C}, Стаж: {GetExperienceInDays()} дн.";
    }
}