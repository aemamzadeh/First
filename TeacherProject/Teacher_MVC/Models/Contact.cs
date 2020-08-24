using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="اجباری است")]
        [MinLength(3)]
        [MaxLength(6)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
