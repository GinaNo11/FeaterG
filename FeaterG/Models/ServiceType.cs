using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FeaterG.Models
{
    public class ServiceType
    {
        [Key]
        public int  Id { get; set; }

        [Required]
        public string ServiceName { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
