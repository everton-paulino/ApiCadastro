using Cadastro.Domain;
using Cadastro.Repository.Interface;
using MongoDB.Driver;

namespace Cadastro.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly IMongoCollection<Company> _collectionCompany;
        public CompanyRepository()
        {
            var client = new MongoClient(@"mongodb://localhost:27017");
            var database = client.GetDatabase("DBCRUD");
            _collectionCompany = database.GetCollection<Company>("Company");
        }
        public Company CreateCompany(Company company)
        {
            _collectionCompany.InsertOne(company);

            return company;
        }

        public string DeleteCompany(string CompanyKey)
        {
            var company = _collectionCompany.DeleteOneAsync(x => x.Key == CompanyKey);

            return CompanyKey;
        }

        public List<Company> GetAll()
        {
            var companies = _collectionCompany.Find(b => b.IsActive).ToList();

            return companies;
        }

        public Company GetCompanyByKey(string CompanyKey)
        {
            var company = _collectionCompany.Find(p => p.Key == CompanyKey).FirstOrDefault();

            return company;
        }

        public Company UpdateCompany(Company company)
        {
            _collectionCompany.ReplaceOneAsync(c => c.Key == company.Key, company);

            return company;
        }
    }
}