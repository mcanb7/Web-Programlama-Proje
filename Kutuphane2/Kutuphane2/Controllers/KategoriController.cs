using Kutuphane2.Data;
using Kutuphane2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Kutuphane2.UnitOfWork3;



namespace Kutuphane2.Controllers
{
    public class KategoriController : Controller
    {
        
        UnitOfWork unitOfWork;
        public KategoriController()
        {
            unitOfWork = new UnitOfWork();
        }
        
        public IActionResult Index()
        {
            var kategoriler = unitOfWork.GetRepository<Kategori>().GetAll();
            return View(kategoriler);
        }
        
        //[HttpPost]
        //public JsonResult EkleJson(string ktgAd)
        //{
        //    Kategori ktgr1 = new Kategori();
        //    ktgr1.KategoriAdi = ktgAd;
        //    var eklenenKtg = unitOfWork.GetRepository<Kategori>().Add(ktgr1);
        //    unitOfWork.SaveChanges();
        //    return Json{
        //        new
        //        {
        //            Result = new
        //            {

        //            }
        //        }
        //    };

        //}
    }
}
