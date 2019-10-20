/*
 // I, Andre madar, student number 000393681, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
     */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1b.Data;
using Lab1b.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab1b.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUser>userManager,RoleManager<IdentityRole> RoleManager)
        {
            _userManager = userManager;
            _roleManager = RoleManager;
        }

        public async Task<IActionResult> SeedRoles()
        {
            // Add 2 new Users
            ApplicationUser user1 = new ApplicationUser
            {
                Email = "John@Doe.com",
                FirstName="John",
                LastName="Doe",
                UserName = "John@Doe.com",
                BirthDate = "11/06/1994"

            };
            ApplicationUser user2 = new ApplicationUser
            {
                Email = "Jane@Doe.com",
                FirstName="Jane",
                LastName="Doe",
                UserName = "Jane@Doe.com",
                BirthDate ="11/06/1995"
            };

            // Add to DB
            IdentityResult result = await _userManager.CreateAsync(user1, "Mohawk1!");
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to add new user!" });

             result = await _userManager.CreateAsync(user2, "Mohawk1!");
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to add new user!" });
            
            
            // Add 2 new Roles
            result = await _roleManager.CreateAsync(new IdentityRole("Employee"));
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to add new role!" });
            result = await _roleManager.CreateAsync(new IdentityRole("Superviser"));
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to add new role!" });
            // Assign the new users to the roles
            result = await _userManager.AddToRoleAsync(user1, "Employee");
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to assign new role!" });

            result = await _userManager.AddToRoleAsync(user2, "Superviser");
            if (!result.Succeeded)
                return View("Error", new ErrorViewModel { RequestId = "Failed to assign new role!" });
            return RedirectToAction("Index","Home");
        }
    }
}