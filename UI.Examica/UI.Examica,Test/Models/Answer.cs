using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Examica_Test.Models
{
    public class Answer
    {
        public string UserAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public Exam Exam { get; set; }
        public Question Question { get; set; }
        public IdentityUser User { get; set; }
    }
}
