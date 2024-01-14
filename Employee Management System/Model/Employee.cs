namespace EmployeeNamespace.Model
    // The Employee class represents an entity in the Employee Management System (EMS).
    // It follows a strictly typed approach, using strongly-typed properties
    // to ensure data integrity and type safety. This approach enhances code
    // readability, maintainability, and helps catch errors at compile-time.
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
}

