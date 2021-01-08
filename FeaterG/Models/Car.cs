using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaterG.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Plate { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Made { get; set; }

        [Required]
        public string Color { get; set; }


        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
