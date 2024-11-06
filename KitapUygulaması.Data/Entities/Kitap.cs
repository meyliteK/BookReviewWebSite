﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapUygulaması.Data.Entities
{
    public class Kitap : BaseEntity<int>
    {

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; } //list olabilir

        public string Scenarist { get; set; }

        public string Cast { get; set; } // liste olucak düzelt

        public string Image { get; set; }

        public float Star { get; set; }

        public int RunTime { get; set; }

        public string Overview { get; set; }

        public int Date { get; set; }

        public List<Rewiew>? Rewiews { get; set; }

        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
