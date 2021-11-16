using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Admin.Entities;
using StockMarket.Admin.Repositories;
using System;
using System.Collections.Generic;

namespace StockMarket.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyRepository repo = new CompanyRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetCompanies()
        {
            try
            {
                List<Company> companies = repo.GetAllCompany();
                return Ok(companies);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetCompany/{CompanyName}")]
        public IActionResult Get(string CompanyName)
        {
            try
            {
                Company company = repo.GetCompanyByName(CompanyName);
                return Ok(company);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteCompany(string id)
        {
            try
            {
                repo.DeleteCompany(id);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddCompany")]
        public IActionResult AddCompany(Company company)
        {
            try
            {
                repo.AddCompany(company);
                return Ok("Added");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditItem")]
        public IActionResult EditItem(Company item) //Update Item
        {
            try
            {
                repo.UpdateCompany(item);
                return Ok("Updated");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
