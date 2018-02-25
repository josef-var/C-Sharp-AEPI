using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExamenFinal.Models
{
    public class ExamenFinalContext : DbContext
    {
        public ExamenFinalContext (DbContextOptions<ExamenFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ExamenFinal.Models.MultChoice> MultChoice { get; set; }
    }
}
