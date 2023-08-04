using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Entities
{
    class User:Entity
    {
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Tel { get; set; }
        public int YetkiId { get; set; }
    }
}
