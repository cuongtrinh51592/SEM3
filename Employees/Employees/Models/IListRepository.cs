using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public interface IListRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
