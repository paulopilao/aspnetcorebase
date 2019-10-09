using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreBase.Data
{
    public class Context: IdentityDbContext
    {
        public Context(DbContextOptions<Context> options): base(options){}
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
