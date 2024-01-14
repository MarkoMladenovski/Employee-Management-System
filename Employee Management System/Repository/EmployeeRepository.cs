
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeNamespace.Model; 

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext _context;

    public EmployeeRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task CreateEmployeeAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        _context.Entry(employee).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
}
// While traditional CRUD operations (Create, Read, Update, Delete) have been widely used,
// there are more modern and effective practices available, such as Command Query Responsibility
// Segregation (CQRS) and Event Sourcing. These patterns offer better scalability, improved
// separation of concerns, and enhanced performance in certain scenarios. Consider exploring
// these alternatives when designing systems with complex data processing requirements.
// For simpler scenarios, traditional CRUD may still be appropriate, but it's valuable to be
// aware of evolving architectural patterns that can provide additional benefits.