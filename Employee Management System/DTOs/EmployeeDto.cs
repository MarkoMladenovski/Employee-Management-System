using System;

namespace EmployeeNamespace.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public string Email { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
       
    }
}

