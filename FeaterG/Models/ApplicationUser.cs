using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeaterG.Models
{
    public class ApplicationUser :IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
