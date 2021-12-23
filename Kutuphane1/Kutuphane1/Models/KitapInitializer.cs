using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane1.Models
{
    public class KitapInitializer : DropCreateDatabaseIfModelChanges<KitapContext>
    {
        protected override void Seed(KitapContext context)
        {
            List<Kategori> kategoriler = new List<Kategori>()
            {
                new Kategori(){KategoriAdi="Falan"},
                new Kategori(){KategoriAdi="Saçma"},
                new Kategori(){KategoriAdi="Fistan"},
                new Kategori(){KategoriAdi="Zırt Pırt"},
                new Kategori(){KategoriAdi="Zart Zurt"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }

            context.SaveChanges();

            List<Yazar> yazarlar = new List<Yazar>()
            {
                new Yazar(){YazarAdi="aaa"},
                new Yazar(){YazarAdi="Saçvavama"},
                new Yazar(){YazarAdi="Fistvasvasan"},
                new Yazar(){YazarAdi="Zırt Pıasvasrt"},
                new Yazar(){YazarAdi="Zaasasdrt Zurt"},
            };
            foreach (var item in yazarlar)
            {
                context.Yazarlar.Add(item);
            }

            context.SaveChanges();

            List<Kitap> kitaplar = new List<Kitap>()
            {
                new Kitap(){KitapAdi="ZAAA",KitapYazari="aaa",KitapCikis=DateTime.Now.AddDays(-5000),KitapEklenme=DateTime.Now,KtokAdedi=5,KategoriId=1,YazarId=1},
                new Kitap(){KitapAdi="gdfdfghdfg",KitapYazari="bbbb",KitapCikis=DateTime.Now.AddDays(-7000),KitapEklenme=DateTime.Now,KtokAdedi=7,KategoriId=1,YazarId=1},

            };
            foreach (var item in kitaplar)
            {
                context.Kitaplar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
