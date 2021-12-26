using Kutuphane2.Migrations;
using Kutuphane2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Data
{
    public class Context:DbContext
    {
        public Context():base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>("Context"));
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kitap> Kitaplar{ get; set; }
        public DbSet<OduncAl> OduncKitaplar { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yazar> Yazarlar{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //S harfi kaldirma
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

}
