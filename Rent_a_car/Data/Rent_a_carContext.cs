using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rent_a_car.Models;

namespace Rent_a_car.Data
{
    public class Rent_a_carContext : DbContext
    {
        public Rent_a_carContext (DbContextOptions<Rent_a_carContext> options)
            : base(options)
        {
        }

        public DbSet<Rent_a_car.Models.Car> Car { get; set; }
    }
}
