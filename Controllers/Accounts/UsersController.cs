﻿using AgrixemBackend;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgrixemAPI.Controllers.Accounts
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        public UsersController(ApplicationDbContext context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        // GET: api/users/farmID
        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetUsers(int id)
        {
            //Get all users who have belong to a farm
            var users = await _userManager.Users.Where(e => e.FarmID == id).ToListAsync();

            if (users == null)
            {
                return NotFound();
            }

            //Security you can never ever trust the client

            List<User> Users = new List<User>();

            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);

                Users.Add(
                    new User
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        MiddleName = user.MiddleName,
                        DOB = user.DOB,
                        Sex = user.Sex,
                        NRC = user.NRC,
                        PasswordHash = role.FirstOrDefault(),
                        PhoneNumber = user.PhoneNumber,
                        Email = user.Email,
                        SecurityStamp = "-",
                        ConcurrencyStamp = "-"
                    }
                    );
            }

            return Users;
        }
        // DELETE: api/Users/agsghh-svssgsg-gsgsg
        [HttpDelete("{email}")]
        public async Task<ActionResult<User>> DeleteGrowth(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            
            if (user == null)
            {
                return NotFound();
            }

            await _userManager.DeleteAsync(user);

            return user;
        }

    }
}
