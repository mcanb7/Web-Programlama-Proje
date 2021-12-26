using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Models
{
    public class Uye
    {
        [Key]
        public int Id{ get; set; }


        [Display(Name = "Adınızı Giriniz:")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string UyeAdi{ get; set; }


        [Display(Name = "Soyadınızı Giriniz:")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string UyeSoyadi{ get; set; }


        [Display(Name = "Mail Adresinizi Giriniz:")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        [Column(TypeName = "varchar")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Mail{ get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Kategori Adını Giriniz:")]
        [Column(TypeName = "char")]
        [MaxLength(32),MinLength(32)]
        public string Sifre{ get; set; }
        public DateTime KayitTarihi{ get; set; }
        [Required]
        [Column(TypeName ="char")]
        [MaxLength(1), MinLength(1)]
        public char Yetki { get; set; }

        public virtual List<OduncAl> OduncKitaplar{ get; set; }
    }
}
