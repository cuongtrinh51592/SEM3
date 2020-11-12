using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models.ViewModels
{
    public class ListEmployeesViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
    }
}
