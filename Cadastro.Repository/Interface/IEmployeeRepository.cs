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
        Employee CreateCompany(Employee employee);
        Employee UpdateCompany(Employee employee);
        string DeleteCompany(string employeeKey);
        Employee GetCompanyByKey(string employeeKey);
        List<Employee> GetAll();
    }
}
