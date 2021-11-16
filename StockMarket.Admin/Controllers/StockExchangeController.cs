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
    public class StockExchangeController : ControllerBase
    {
        private readonly StockExchangeRepository repo = new StockExchangeRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetSE()
        {
            try
            {
                List<StockExchange> stockExchanges = repo.GetAllSE();
                return Ok(stockExchanges);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetSEName/{name}")]
        public IActionResult GetSEName(string name)
        {
            try
            {
                StockExchange stockExchange = repo.GetSEByName(name);
                return Ok(stockExchange);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetSE/{id}")]
        public IActionResult GetSEId(int id)
        {
            try
            {
                StockExchange stockExchange = repo.GetSE(id);
                return Ok(stockExchange);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteSEName/{name}")]
        public IActionResult Delete(string name)
        {
            try
            {
                repo.DeleteSEByName(name);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteSE/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                repo.DeleteSE(id);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddSE")]
        public IActionResult AddSE(StockExchange stockExchange)
        {
            try
            {
                repo.AddSE(stockExchange);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateSE")]
        public IActionResult EditSE(StockExchange stockExchange)
        {
            try
            {
                repo.UpdateSE(stockExchange);
                return Ok("Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
