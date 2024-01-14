
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeNamespace.Model; 

public interface IEmployeeRepository
{
    Task<List<Employee>> GetEmployeesAsync();
    Task<Employee> GetEmployeeByIdAsync(int id);
    Task CreateEmployeeAsync(Employee employee);
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(int id);
}
// Dependency Injection (DI) is a design pattern that facilitates
// the management of object dependencies in a software application.
// Instead of a component creating its dependencies directly,
// dependencies are provided ("injected") from the outside,
// promoting loose coupling, modularization, and testability.
// DI helps improve code maintainability, scalability, and
// enables easier unit testing by allowing components to be easily
// replaced or mocked. In this project, DI is utilized to inject
// dependencies, such as services, into controllers, promoting
// a modular and decoupled architecture.