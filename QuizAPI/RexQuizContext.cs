using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QuizAPI.Models;

namespace QuizAPI
{
    public partial class RexQuizContext : DbContext
    {

        public RexQuizContext(DbContextOptions<RexQuizContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public virtual DbSet<User> Users { get; set; }
        
    }

    public class InitilizaDatabase
    {
        public InitilizaDatabase()
        {
            RexQuizContext context = new RexQuizContext(new DbContextOptions<RexQuizContext>());
            context.Database.EnsureCreated();
            context.Database.GenerateCreateScript();

        }

    }
}
