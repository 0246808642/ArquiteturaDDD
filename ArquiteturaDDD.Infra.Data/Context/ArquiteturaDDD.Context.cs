using ArquiteturaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace ArquiteturaDDD.Infra.Data.Context
{
    public class ArquiteturaDDD : DbContext
    { 
        public ArquiteturaDDD()
        : base ("ArquiteturaDDDOne")
        {
        
        }

        public DbSet<Cliente> Clientes { get; set; }    
    }
}
