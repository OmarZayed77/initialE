using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class Result
    {
        public int Grade { get; set; }
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public IdentityUser User { get; set; }
        public Exam Exam { get; set; }
    }
}
