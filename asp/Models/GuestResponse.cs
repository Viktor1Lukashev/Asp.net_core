using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.Models
{
    public class GuestResponse
    {

        [Required(ErrorMessage ="Please, enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please, enter your email adress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email adress")]
        public string NEmail { get; set; }
        [Required(ErrorMessage = "Please, enter your name")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please, specify wheather you attend")]
        public bool? WillAttend { get; set; }

    }
}
