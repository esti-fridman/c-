using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_c_
{
    internal class DbConnectionManagemen:DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=sqlsrv;Database=BooksDB;Trusted_Connection=True;Encrypt=False");
        }
      
    }
}
