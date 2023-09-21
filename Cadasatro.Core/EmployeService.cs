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

        public Employee CreateEmployee(Employee employee)
        {
            return _employeeRepository.CreateEmployee(employee);
        }

        public string DeleteEmployee(string employeeKey)
        {
            return _employeeRepository.DeleteEmployee(employeeKey);
        }

        public List<Employee> GetAll()
        {
            var employees = _employeeRepository.GetAll();

            return employees;
        }

        public Employee GetEmployeeByKey(string employeeKey)
        {
            var employee = _employeeRepository.GetEmployeeByKey(employeeKey);

            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return _employeeRepository.UpdateEmployee(employee);
        }
    }
}





  