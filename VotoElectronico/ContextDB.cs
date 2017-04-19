using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace VotoElectronico
{
    public class ContextDB : DbContext
    {
        public DbSet<Votante> Votantes { get; set; }
        public DbSet<Antecedente> Antecedentes { get; set; }
        public DbSet<Voto> Votos { get; set; }

    }
}
