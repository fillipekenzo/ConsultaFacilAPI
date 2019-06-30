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
        public Posto Posto { get; set; }
        public TipoConsulta TipoConsulta { get; set; }
        [ForeignKey("PostoId")]
        public int PostoId { get; set; }
        [ForeignKey("TipoConsultaId")]
        public int TipoConsultaId { get; set; }
        

    }
}
