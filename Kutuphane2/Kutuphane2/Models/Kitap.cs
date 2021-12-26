using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Models
{
    public class Kitap
    {
        [Key]
        public int Id{ get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string KitapAdi{ get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public int StokAdet{ get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public DateTime EklenmeTarihi{ get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public int YazarId { get; set; }
        public virtual Yazar Yazar { get; set; }
        public virtual List<Kategori> Kategoriler{ get; set; }

    }
}
