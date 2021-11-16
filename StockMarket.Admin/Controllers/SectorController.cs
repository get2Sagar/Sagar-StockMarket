using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Admin.Entities;
using StockMarket.Admin.Repositories;
using System;

namespace StockMarket.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly SectorRepository repo = new SectorRepository();
        [HttpPost]
        [Route("AddSector")]
        public IActionResult Add(Sector sector)
        {
            try
            {
                repo.AddSector(sector);
                return Ok("Added");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
