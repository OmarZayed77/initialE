using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class ComplexQuestion
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public List<Question> Questions { get; set; }
    }
}
