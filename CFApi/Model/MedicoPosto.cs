using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class MedicoPosto : EntityBase
    {
        public Medico Medico { get; set; }
        public Posto Posto { get; set; }
    }
}
