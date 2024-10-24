using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Infra.APPInfraConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class AppContextDB : DbContext
    {
        public AppContextDB(DbContextOptions options) : base(options) { }
        public DbSet<Pessoa> Pessoas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ConfigurationAPP());
        }
    }
}
