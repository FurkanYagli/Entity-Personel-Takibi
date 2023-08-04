using Person.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Context
{

    class PersonContext :DbContext
    {
        public DbSet<Persons> Persons{ get; set; }
        public DbSet<Authority> Authorities{ get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<EntryMobility> EntryMobilities{ get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<StaffMobility> StaffMobilities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
