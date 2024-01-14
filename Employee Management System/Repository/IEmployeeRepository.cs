
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
