using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCUnitTesting.Models
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Salutation> Salutations { get; set; }
        public DbSet<State> States { get; set; }
    }
}