using Cadastro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        string DeleteEmployee(string employeeKey);
        Employee GetEmployeeByKey(string employeeKey);
        List<Employee> GetAll();
    }
}
