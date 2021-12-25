using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Models
{
    public class Yazar
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Yazar Adını Giriniz:")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Column(TypeName = "varchar")]
        [MaxLength(15)]
        public string YazarAdi { get; set; }

    }
}
