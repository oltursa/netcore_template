using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using RazorPages.Services;

namespace RazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IEmployeeRepository _repo;


        public IndexModel(IConfiguration config, IEmployeeRepository repo)
        {
            _config = config;
            _repo = repo;
        }
        public string titulo { get; set; }
        public void OnGet()
        {
            var lista = _repo.GetAllEmployess();
            titulo = "";
        }
    }
}