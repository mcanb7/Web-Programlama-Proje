using Kutuphane2.Data;
using Kutuphane2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            List<int> kategoriIds = new List<int>();
            kategoriIds.Add(1);
            kategoriIds.Add(2);

            List<Kategori> kategoriler = new List<Kategori>();
            foreach (var item in kategoriIds)
            {
                var ktg = context.Kategoriler.FirstOrDefault(x => x.Id == item);
                kategoriler.Add(ktg);
            }

            
            Kitap kitap = new Kitap() {
            KitapAdi="A",
            StokAdet=2,
            EklenmeTarihi=DateTime.Now,
            YazarId = 1,
            Kategoriler = kategoriler
            };
            context.Kitaplar.Add(kitap);
            context.SaveChanges();
            return View();
        }
    }
}
