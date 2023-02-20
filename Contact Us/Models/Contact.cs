using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_Us.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        [StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessage = "Length must be between 1 to 10")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the email")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the massage")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Message { get; set; }
    }
}
