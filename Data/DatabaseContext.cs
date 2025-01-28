using Microsoft.EntityFrameworkCore;
using SportsScheduleProLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsSchedulePro.Data
{
    public class DatabaseContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=SportsScheduleProData.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
