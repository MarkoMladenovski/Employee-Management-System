using System;

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
//In C#, using a strictly typed approach for defining properties and methods in a class means that you explicitly specify the data
//types for all your class members and method return types. This ensures type safety, meaning the compiler will check that the types
//of values assigned to variables or returned by methods are consistent with the declared types, and it will flag any mismatches as
//errors during compilation.

//Here's an example of a strictly typed class in C#:

//csharp
//public class Person
//{
  //  public string Name { get; set; }
    //public int Age { get; set; }

    //public void DisplayInfo()
    //{
      //  Console.WriteLine($"Name: {Name}, Age: {Age}");
    //}
//}
