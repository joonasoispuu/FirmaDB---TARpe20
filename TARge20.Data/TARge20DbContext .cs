using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Branch_office> Branch_office { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Employee_access> Employee_access { get; set; }
        public DbSet<Employees_childres> Employees_childres { get; set; }
        public DbSet<Employees_location> Employees_location { get; set; }
        public DbSet<Health_inspection> Health_inspection { get; set; }
        public DbSet<Intranet_access> Intranet_access { get; set; }
        public DbSet<Loans_from_the_company> Loans_from_the_company { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Tips> Tips { get; set; }
        public DbSet<Vacation> Vacation { get; set; }
        public DbSet<Vacation_status> Vacation_status { get; set; }
        public DbSet<Employee_position> Employee_position { get; set; }
    }
}