using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane1.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public DateTime KitapCikis { get; set; }
        public DateTime KitapEklenme { get; set; }
        public int KtokAdedi { get; set; }
        public Kategori Kategori { get; set; }
        public int KategoriId { get; set; }
       
        public Yazar Yazar { get; set; }
        public int YazarId { get; set; }
        
    }
}
