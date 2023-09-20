using Cadastro.Domain;
using Cadastro.Repository.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IMongoCollection<Employee> _collectionEmployee;
        public EmployeeRepository()
        {
            var client = new MongoClient(@"mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionEmployee = database.GetCollection<Employee>("Employee");

        }
        public Employee CreateCompany(Employee employee)
        {
            _collectionEmployee.InsertOne(employee);

            return employee;
        }

        public string DeleteCompany(string employeeKey)
        {
            var employee = _collectionEmployee.DeleteOneAsync(x => x.Key == employeeKey);

            return employeeKey;
        }

        public List<Employee> GetAll()
        {
            var employees = _collectionEmployee.Find(b => b.IsActive).ToList();

            return employees;
        }

        public Employee GetCompanyByKey(string employeeKey)
        {
            var employee = _collectionEmployee.Find(p =>  p.Key == employeeKey).FirstOrDefault();

            return employee;
        }

        public Employee UpdateCompany(Employee employee)
        {
            _collectionEmployee.ReplaceOneAsync(c => c.Key == employee.Key, employee);

            return employee;
        }
    }
}
