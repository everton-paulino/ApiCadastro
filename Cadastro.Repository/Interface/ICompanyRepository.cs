using Cadastro.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Repository.Interface
{
    public interface ICompanyRepository
    {
        Company CreateCompany(Company company);
        Company UpdateCompany(Company company);
        string  DeleteCompany(string CompanyKey);
        Company GetCompanyByKey(string CompanyKey);
        List<Company> GetAll();
    }
}
