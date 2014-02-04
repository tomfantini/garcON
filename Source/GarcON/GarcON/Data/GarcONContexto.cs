using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using GarcON.Model;

namespace GarcON.Data
{
    public class GarcONContexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
