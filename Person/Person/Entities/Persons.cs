using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Entities
{
    class Persons : Entity
    {
        public string Soyad { get; set; }
        public int SehirId { get; set; }
        public int MeslekId { get; set; }
        public int Maas { get; set; }
    }
}
