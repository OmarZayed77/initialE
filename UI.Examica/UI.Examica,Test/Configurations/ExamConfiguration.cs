using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Examica_Test.Models;

namespace UI.Examica_Test.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasMany(e => e.Questions);
            builder.Property(e => e.Name).IsRequired()
                                        .HasMaxLength(100);
            builder.HasOne(e => e.Organization)
                .WithMany(o => o.Exams);
        }
    }
}
