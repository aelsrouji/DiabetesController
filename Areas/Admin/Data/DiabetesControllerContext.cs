using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DiabeticsHelper;

namespace DiabetesController.Data
{
    public class DiabetesControllerContext : DbContext
    {
        public DiabetesControllerContext (DbContextOptions<DiabetesControllerContext> options)
            : base(options)
        {
        }

        public DbSet<DiabeticsHelper.City> City { get; set; }
    }
}
