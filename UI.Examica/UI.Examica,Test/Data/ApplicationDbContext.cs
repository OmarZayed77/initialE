using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UI.Examica_Test.Configurations;
using UI.Examica_Test.Models;

namespace UI.Examica_Test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<ComplexQuestion> ComplexQuestions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AnswerConfiguration());
        }
    }
    
}
