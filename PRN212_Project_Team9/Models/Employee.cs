using System;
using System.Collections.Generic;

namespace PRN212_Project_Team9.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Position { get; set; }

    public DateTime? HireDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
