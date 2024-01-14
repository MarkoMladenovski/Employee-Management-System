
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using EmployeeNamespace.Model;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ComponentModel.Design;
using AutoMapper;
using EmployeeNamespace.DTOs;
using EmployeeNamespace.Repositories;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class EmployeeController : Controller
{
    public IActionResult Index(string id)
    {
        var employeeDto = new EmployeeDto
        }
    EmployeeId = 1,
    Name = Joe,
    Position = "Software Developer",
    Salary = 70.00
}
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public IActionResult GetEmployee(int id)
    {
        var employeeEntity = _employeeRepository.GetEmployeeByIdAsync(id).Result;
        var employeeDto = _mapper.Map<EmployeeDto>(employeeEntity);
        return View(employeeDto);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
return View(employeeDto);
}
{
    private readonly AppDbContext _context;

    public EmployeeController(AppDbContext context)
    {
        _context = context;
    }

    
    public async Task<IActionResult> Index()
    {
        var employees = await _context.Employees.ToListAsync();
        return View(employees);
    }

    
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employee = await _context.Employees
            .FirstOrDefaultAsync(m => m.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        return View(employee);
    }

    
    public IActionResult Create()
    {
        return View();
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,EmployeeId,Position,Salary")] Employee employee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }

   
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employee = await _context.Employees.FindAsync(id);

        if (employee == null)
        {
            return NotFound();
        }

        return View(employee);
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,EmployeeId,Position,Salary")] Employee employee)
    {
        if (id != employee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(employee.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(employee);
    }
// Using a switch statement instead of multiple if-else conditions
// when dealing with a variable that can have distinct, mutually exclusive values.
// Switch statements provide clearer and more efficient code in scenarios where the variable's
// value needs to be compared against multiple possibilities. This improves code readability
// and maintainability by eliminating unnecessary nesting and making the logic more concise.
// Switch statements are especially advantageous when handling a limited set of known values,
// contributing to a more structured and easily understandable code flow.


public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employee = await _context.Employees
            .FirstOrDefaultAsync(m => m.Id == id);

        if (employee == null)
        {
            return NotFound();
        }

        return View(employee);
    }

    
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EmployeeExists(int id)
    {
        return _context.Employees.Any(e => e.Id == id);
    }
}
//EmployeeExists, with DDD would go to the service or in the object as a function. As for a classic separetion of pattern it 
//would go in the service outside of the Controller. It would be better suited in a service or a better separeted layer,
//as the highest layer should`t do any logic in more complex cleaner solution.