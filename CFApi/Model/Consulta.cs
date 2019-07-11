using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class Consulta:EntityBase
    {
        
       
        public int UsuarioId { get; set; }
        public int PostoId { get; set; }
        public int MedicoId { get; set; }
        public int TipoConsultaId { get; set; }


        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
        [ForeignKey("TipoConsultaId")]
        public TipoConsulta TipoConsulta { get; set; }
        [ForeignKey("PostoId")]
        public virtual Posto Posto { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
        public DateTime DataHora { get; set; }
    }
}
