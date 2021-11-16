using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AccountAPI.Entities;
using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Repositories;
using System;

namespace StockMarket.AccountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserRepository repository = new UserRepository();
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(Users user)
        {
            try
            {
                repository.Register(user);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(Login login)
        {
            try
            {
                Users user = repository.Validate(login);
                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
