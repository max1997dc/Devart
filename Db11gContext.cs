using ConsoleAppDevart.Identities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevart
{
    class Db11gContext : DbContext
    {
        public const string ConnectionStringDefault = "User Id=xx;Password=xx;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=xx ) (PORT=1521)))(CONNECT_DATA=(SID=xx)));";

        public Db11gContext(DbContextOptions<Db11gContext> options) : base(options)
        {

        }

        public DbSet<TbManMeEquipment> TbManMeEquipment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
