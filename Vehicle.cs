using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Vehicles
{
    public class Vehicle
    {
        public int Id { get; set; }       
        [Range(1950, 2050)]
        public int Year { get; set; }
        [Required(ErrorMessage = "Make is required")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }
    }
}
