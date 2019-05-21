using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Level { get; set; }
        public string Type { get; set; }
        public int Mark { get; set; }
        public bool IsPublic { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public List<Option> Options { get; set; }
        public List<Exam> Exams { get; set; }
        public List<ComplexQuestion> ComplexQuestions { get; set; }
    }
}
