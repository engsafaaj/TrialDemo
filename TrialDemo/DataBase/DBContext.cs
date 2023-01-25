using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialDemo.DataBase
{
   public class DBContext:DbContext
    {
        public DBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=TrialDemoDataBase;User id=sa;Password=12345");
        }
        public DbSet<Activeation> Activeation { get; set; }
    }
}
