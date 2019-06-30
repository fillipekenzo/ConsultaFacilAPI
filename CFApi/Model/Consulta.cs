using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class Consulta:EntityBase
    {
        public virtual Posto Posto { get; set; }
        public Usuario Usuario { get; set; }
        public Medico Medico { get; set; }
        public TipoConsulta TipoConsulta { get; set; }
       
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        [ForeignKey("PostoId")]
        public int PostoId { get; set; }
        [ForeignKey("MedicoId")]
        public int MedicoId { get; set; }
        [ForeignKey("TipoConsultaId")]
        public int TipoConsultaId { get; set; }
       
        public DateTime DataHora { get; set; }
    }
}
