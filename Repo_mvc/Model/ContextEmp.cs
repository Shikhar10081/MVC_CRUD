
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_mvc.Model
{
      public class ContextEmp:DbContext
    {
        public DbSet<Employee> EmployeeInfo { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SHIKHARVERMA\\SQLEXPRESS;Database=MyDb1;Integrated Security=true;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }

    }


}
