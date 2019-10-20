using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1b.Data
{
    public class ApplicationUser:IdentityUser
    {
 
        [Required(ErrorMessage = "First name musn't be empty!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name musn't be empty!")]
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string BirthDate { get; set; }

    }
}
