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
    public class IpoController : ControllerBase
    {
        private readonly IpoRepository rep = new IpoRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetIpos()
        {
            try
            {
                List<Ipo> ipos = rep.GetAllIpo();
                return Ok(ipos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIpo/{name}")]
        public IActionResult GetIpo(string name)
        {
            try
            {
                Ipo ipo = rep.GetIpoByName(name);
                return Ok(ipo);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetIpoId/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Ipo ipo = rep.GetIpoById(id);
                return Ok(ipo);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteIpoName/{name}")]
        public IActionResult Delete(string name)
        {
            try
            {
                rep.DeleteByName(name);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteIpo/{id}")]
        public IActionResult DeleteId(int id)
        {
            try
            {
                rep.DeleteIpo(id);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddIpo")]
        public IActionResult AddIpo(Ipo ipo)
        {
            try
            {
                rep.AddIpo(ipo);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("EditIpo")]
        public IActionResult EditIpo(Ipo ipo)
        {
            try
            {
                rep.UpdateIpo(ipo);
                return Ok("Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
