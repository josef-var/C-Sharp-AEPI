using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ebay.Models
{
    public class EbayContext : DbContext
    {
        public EbayContext (DbContextOptions<EbayContext> options)
            : base(options)
        {
        }

        public DbSet<Ebay.Models.Product> Product { get; set; }
    }
}
