using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Entities
{
    class Log : Entity
    {
        public int KullaniciId { get; set; }
        public int SayfaId { get; set; }
        public int IslemId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
