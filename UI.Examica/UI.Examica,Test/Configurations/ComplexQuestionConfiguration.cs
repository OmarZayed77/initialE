using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Examica_Test.Models;

namespace UI.Examica_Test.Configurations
{
    public class ComplexQuestionConfiguration : IEntityTypeConfiguration<ComplexQuestion>
    {
        public void Configure(EntityTypeBuilder<ComplexQuestion> builder)
        {
            builder.HasMany(c => c.Questions);
            builder.HasOne(c => c.Organization)
             .WithMany(o => o.ComplexQuestions);
        }
    }
}
