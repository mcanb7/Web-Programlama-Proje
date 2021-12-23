using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane1.Models
{
    public class KitapContext : DbContext
    {
        public KitapContext()
        {
            Database.SetInitializer(new KitapInitializer());
        }    
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
    }
}
