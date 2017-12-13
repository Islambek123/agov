using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdasd.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("connect")
        { }
        
        public DbSet<Login> login { get; set; }

    }
}
