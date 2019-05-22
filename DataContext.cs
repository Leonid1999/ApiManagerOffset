using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiManeger
{

    class DataContext : DbContext
    {
        public DataContext()
            : base("DbConnection")
        { }

        public DbSet<TypeMessege> TypeMessege { get; set; }

    }
}
