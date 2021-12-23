using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Kutuphane1.Models;

namespace Kutuphane1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Kutuphane1.Models.Kitap> Kitap { get; set; }
        public DbSet<Kutuphane1.Models.Kategori> Kategori { get; set; }
        public DbSet<Kutuphane1.Models.Yazar> Yazar { get; set; }
    }
}
