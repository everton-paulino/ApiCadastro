using Cadasatro.Core.Interface;
using Cadastro.Core;
using Cadastro.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCadastro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CompanyRequest company)
        {
            var companyRequest = new CompanyRequest();

            var companyCreate = new Company();

            companyCreate.CompanyName = company.CompanyName;

            var companyResponse = _companyService.CreateCompany(companyCreate);

            return Ok(companyCreate);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var companies = _companyService.GetAll();

            return Ok(companies);
        }

        [HttpGet("{key}")]
        public IActionResult GetByKey([FromRoute] string key)
        {
            var company = _companyService.GetCompanyByKey(key);

            if (company is null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [HttpPut("{key}")]
        public IActionResult Put(string key,[FromBody]CompanyUpdate companyUpdate)
        {
            var company = _companyService.GetCompanyByKey(key);

            if (company is null)
            {
                return NotFound();
            }

            company.Updated = DateTime.Now;
            company.CompanyName = companyUpdate.CompanyName;

            var companyresponse = _companyService.UpdateCompany(company);

            return Ok(companyresponse);
        }

        [HttpDelete("{key}")]
        public IActionResult Delete(string key)
        {
            var company = _companyService.GetCompanyByKey(key);

            if (company is null)
            {
                return NotFound();
            }

            var companyresponse = _companyService.DeleteCompany(key);

            return NoContent();

        }
    }
}
