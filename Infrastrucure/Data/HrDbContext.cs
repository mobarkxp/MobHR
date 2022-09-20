using Domin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Data
{
    public class HrDbContext:DbContext
    {
        public HrDbContext(DbContextOptions<HrDbContext> options) : base(options)
        {

        }

        public DbSet<Department>? Departments { get; set; }
        public DbSet<Gender>? Genders { get; set; }
        public DbSet<Nationality>? Nationalities { get; set; }
        public DbSet<MarrigeStatus>? MarrigeStatuses { get; set; }
        public DbSet<EmployeeWorkStatus>? EmployeeWorkStatuses { get; set; }
        public DbSet<Job>? Jobs { get; set; }

    }
}
