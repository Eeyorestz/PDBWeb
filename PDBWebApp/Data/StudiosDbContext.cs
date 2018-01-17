using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PDBWebApp.Models;

namespace PDBWebApp.Data
{
    public class PDBWebAppDbContext : DbContext
    {
        public PDBWebAppDbContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Studios> Studioses { get; set; }
        public DbSet<Workouts> Workouts { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<FillInfo> FillInfo { get; set; }
    }
}
