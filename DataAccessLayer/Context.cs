using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DataAccessLayer
{

    public class Context : DbContext
    {
        public Context() : base("DbConnection") { }
        public DbSet<Ship> Ships { get; set; }
    }
}
