using System;

public class HourlyManager : Employee
{
    public float HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public HourlyManager(string fullName, DateTime hireDate, float hourlyRate)
        : base(fullName, 0, hireDate) // зарплата по умолчанию 0
    {
        HourlyRate = hourlyRate;
        HoursWorked = 0;
        UpdateHourlyId();
    }

    private void UpdateHourlyId()
    {
        Id = $"hourly-{Id}";
    }

    public void AddHours(int hours)
    {
        if (hours < 0)
            throw new ArgumentException("Часы не могут быть отрицательными.");
        HoursWorked += hours;
    }

    public override float GetSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public override string ToString()
    {
        return
            $"Hourly Manager: [{Id}] {Name}, Часов: {HoursWorked}, Ставка: {HourlyRate:C}, Зарплата: {GetSalary():C}";
    }
}