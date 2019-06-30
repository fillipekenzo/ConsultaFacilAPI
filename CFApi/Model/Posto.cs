using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class Posto:EntityBase
    {
        public string Nome { get; set; }
        public long Latitude { get; set; }
        public long Lagitude { get; set; }
    }
}
