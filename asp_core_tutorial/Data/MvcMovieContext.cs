using asp_core_tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_core_tutorial.Data
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
