using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Milestone1.Models;

namespace Milestone1.Data
{
    public class Milestone1Context : DbContext
    {
        public Milestone1Context (DbContextOptions<Milestone1Context> options)
            : base(options)
        {
        }

        public DbSet<Milestone1.Models.Product> Product { get; set; }
    }
}
