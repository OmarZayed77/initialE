using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public IdentityUser Owner { get; set; }
        // Organization Members
        public List<IdentityUser> Admins { get; set; }
        public List<IdentityUser> Examiners { get; set; }
        public List<IdentityUser> Examinees { get; set; }
        public List<IdentityUser> Observers { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Question> Questions { get; set; }
        public List<ComplexQuestion> ComplexQuestions { get; set; }
    }
}
