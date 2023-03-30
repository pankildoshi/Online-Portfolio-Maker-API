using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using PresentsYouAPI.Models;

namespace PresentsYouAPI.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PresentsYouDBContext _context;

        public LoginController(PresentsYouDBContext context)
        {
            _context = context;
        }

        // POST: /Login
        [Route("/Login")]
        [HttpPost]
        public async Task<ActionResult<User>> LoginUser(User user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == user.Email);
            if (existingUser != null && existingUser.Password == user.Password)
            {
                return Ok(existingUser);
            }
            return BadRequest();
        }

        // POST: /Register
        [Route("/Register")]
        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(User user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == user.Email);
            if (existingUser == null)
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return Ok(user);
            }

            return BadRequest();
        }
    }
}
