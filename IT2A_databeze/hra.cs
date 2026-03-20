using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2A_databeze
{
    class hra
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Vydavatel { get; set; }
        public int RokVydani { get; set; }
        public string Typ {  get; set; }
        public int Cena { get; set; }
        public bool Vlastnena { get; set; }
    }
}
