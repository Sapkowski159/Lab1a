using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1a.Models
{
    public class Car
    {
        [Key]
        public string ID { get; set; }
        [Required(ErrorMessage = "Make musn't be empty!")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Model musn't be empty!")]
        public string Model { get; set; }
        [Range(1990,2020,ErrorMessage ="Year musn't be empty!")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Vin musn't be empty!")]
        public string VIN { get; set; }
        public string Color { get; set; }
        public string DealershipID { get; set; }

    }
}
