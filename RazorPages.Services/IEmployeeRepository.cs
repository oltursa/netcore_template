using RazorPages.Model;
using System;
using System.Collections.Generic;

namespace RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployess();
    }
}
