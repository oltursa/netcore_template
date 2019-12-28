using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using RazorPages.Model;

namespace RazorPages.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;
        public EmployeeRepository(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<Employee> GetAllEmployess()
        {
            var lista = new List<Employee>();
            lista.Add(new Employee() { Id = 1,Name="oscar" })  ;

            return lista;
        }
    }
}
