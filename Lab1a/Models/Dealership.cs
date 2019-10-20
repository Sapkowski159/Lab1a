using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1a.Models
{
    public class Dealership
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage ="Name musn't be empty!")]

        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Email musn't be empty!")]

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
