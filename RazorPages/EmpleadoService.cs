using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace RazorPages
{
    public class EmpleadoService
    {
        private readonly IConfiguration configuration;
        public EmpleadoService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
    }
}
