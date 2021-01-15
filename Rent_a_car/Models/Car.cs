using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rent_a_car.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Display(Name = "Imagine")]
        public string Img { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Motorizare { get; set; }
        public int An { get; set; }
        public string Cutie { get; set; }
        public int Kilometraj { get; set; }
        [Display(Name = "Motor")]
        public double Cap_cil { get; set; }
        public int Putere { get; set; }
        [Display(Name = "Norma Euro")]
        public string Euro { get; set; }
    }
}
