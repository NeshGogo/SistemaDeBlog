using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace SistemaDeBlog.Models
{
    public class SistemaBlogDBContext: IdentityDbContext
    {
        public DbSet<Publicacion> Publicaciones { get; set; }

        public SistemaBlogDBContext(DbContextOptions<SistemaBlogDBContext> options) : base(options)
        {

        }
    }
}
