using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaterG.Models.ViewModel
{
    public class UserCars
    {
        public ApplicationUser User { get; set; }
        public List<Car> Cars { get; set; }
    }
}
