using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kutuphane2.Models
{
    public class OduncAl
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public int KitapId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public int UyeId { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        public DateTime AlisTarihi { get; set; }
    }
}
