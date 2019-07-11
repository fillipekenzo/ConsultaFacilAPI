using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class Medico:EntityBase
    {
        public string Nome { get; set; }
        
        public int TipoConsultaId { get; set; }

        public ICollection<MedicoPosto> Posto { get; set; }

    }
}
