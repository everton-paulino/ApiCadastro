using Cadasatro.Core.Interface;
using Cadastro.Domain;
using Cadastro.Repository.Interface;

namespace Cadasatro.Core
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;   
        }
        public Company CreateCompany(Company company)
        {
            return _companyRepository.CreateCompany(company);
        }

        public string DeleteCompany(string CompanyKey)
        {
            return _companyRepository.DeleteCompany(CompanyKey);
        }

        public List<Company> GetAll()
        {
            var companies = _companyRepository.GetAll();

            return companies;
        }

        public Company GetCompanyByKey(string CompanyKey)
        {
            var company = _companyRepository.GetCompanyByKey(CompanyKey);

            return company;
        }

        public Company UpdateCompany(Company company)
        {
            return _companyRepository.UpdateCompany(company);
        }
    }
}