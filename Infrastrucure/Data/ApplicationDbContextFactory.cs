using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<HrDbContext>
    {
        public HrDbContext CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<HrDbContext>();
            optionsBuilder.UseSqlServer("server=DESKTOP-MDJHEMJ\\SQLEXPRESS; Database=MubHRDb;Trusted_Connection=True;");

            return new HrDbContext(optionsBuilder.Options);
        }
    }
}
