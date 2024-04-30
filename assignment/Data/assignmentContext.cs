using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using assignment.Joy_Model;

namespace assignment.Data
{
    public class assignmentContext : DbContext
    {
        public assignmentContext (DbContextOptions<assignmentContext> options)
            : base(options)
        {
        }

        public DbSet<assignment.Joy_Model.user> user { get; set; } = default!;
    }
}
