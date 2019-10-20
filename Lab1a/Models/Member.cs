using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1a.Models
{
    public class Member
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "First name musn't be empty!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name musn't be empty!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username musn't be empty!")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Email musn't be empty!")]
        public string Email { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string BirthDate { get; set; }

    }
}
