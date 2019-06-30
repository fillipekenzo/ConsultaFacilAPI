using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFApi.Model
{
    public class Usuario:EntityBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string NumeroSus { get; set; }
        public string Email { get; set; }
    }
}
