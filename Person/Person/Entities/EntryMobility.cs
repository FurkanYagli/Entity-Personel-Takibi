﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Entities
{
    class EntryMobility : Entity
    {
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }
        public string Kod { get; set; }
    }
}
