using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane1.Models
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyad { get; set; }
        public int YazarYas { get; set; }

        public List<Kitap> Kitaplar { get; set; }
    }
}
