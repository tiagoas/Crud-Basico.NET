using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projetoCrudSimples.Models
{
    public class contexto: DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}