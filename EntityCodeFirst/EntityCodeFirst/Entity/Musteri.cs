using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }

        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string MusteriSehir { get; set; }
    }
}
