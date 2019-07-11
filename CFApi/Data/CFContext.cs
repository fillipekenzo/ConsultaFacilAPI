using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CFApi.Model;

    public class CFContext : DbContext
    {
        public CFContext (DbContextOptions<CFContext> options)
            : base(options)
        {
        }

        public DbSet<CFApi.Model.Usuario> Usuario { get; set; }

        public DbSet<CFApi.Model.Posto> Posto { get; set; }

        public DbSet<CFApi.Model.TipoConsulta> TipoConsulta { get; set; }

        public DbSet<CFApi.Model.Medico> Medico { get; set; }

        public DbSet<CFApi.Model.Consulta> Consulta { get; set; }
        public DbSet<CFApi.Model.MedicoPosto> MedicoPosto { get; set; }
}
