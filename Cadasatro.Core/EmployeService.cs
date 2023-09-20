using Cadasatro.Core.Interface;
using Cadastro.Domain;
using Cadastro.Repository;
using Cadastro.Repository.Interface;

namespace Cadastro.Core
{
    public class EmployeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }        

        public Employee CreateCompany(Employee employee)
        {
            return _employeeRepository.CreateCompany(employee);
        }

        public string DeleteCompany(string employeeKey)
        {
            return _employeeRepository.DeleteCompany(employeeKey);
        }

        public List<Employee> GetAll()
        {
            var employees = _employeeRepository.GetAll();

            return employees;
        }

        public Employee GetCompanyByKey(string employeeKey)
        {
            var employee = _employeeRepository.GetCompanyByKey(employeeKey);
            
            return employee;
        }

        public Employee UpdateCompany(Employee employee)
        {
            return _employeeRepository.UpdateCompany(employee);
        }
    }
}
