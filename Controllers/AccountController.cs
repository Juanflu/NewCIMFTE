using Microsoft.AspNetCore.Mvc;
using NewCIMFTE.Models;
using NewCIMFTE.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewCIMFTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountController(IRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
        }

        [HttpGet]
        [Route("list", Name = "list")]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var list = await GeUsersDtoAsync().ConfigureAwait(false);

                return Ok(list);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            try
            {
                Account account = new Account();

                return Ok(account);
            }
            catch
            {
                return BadRequest();
            }
        }

        private async Task<IEnumerable<Account>> GeUsersDtoAsync()
        {
            var accounts = await _accountRepository.GetAsync().ConfigureAwait(false);

            return accounts;
        }
    }
}