using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public List<Question> Questions { get; set; }
        public List<ComplexQuestion> ComplexQuestion { get; set; }
    }
}
