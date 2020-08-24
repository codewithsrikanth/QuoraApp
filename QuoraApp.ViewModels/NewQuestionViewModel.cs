using System;
using System.ComponentModel.DataAnnotations;

namespace QuoraApp.ViewModels
{
    public class NewQuestionViewModel
    {
        [Required]
        public string QuestionName { get; set; }

        [Required]
        public DateTime QuestionDateAndTime { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int VotesCount { get; set; }

        [Required]
        public int AnswersCount { get; set; }

        [Required]
        public int ViewsCount { get; set; }
    }
}
