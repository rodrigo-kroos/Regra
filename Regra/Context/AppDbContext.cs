using Microsoft.EntityFrameworkCore;
using Regra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regra.Context
{
    public class AppDbContext : DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        { 

        }

        public DbSet<Cerveja> Cervejas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
