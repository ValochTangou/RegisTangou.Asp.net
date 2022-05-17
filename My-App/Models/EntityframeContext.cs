using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace My_App.Models
{
    public class EntityframeContext : DbContext
    {
        public EntityframeContext(DbContextOptions<EntityframeContext> options)
              : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Courses> Courses { get; set; }



    }

}
