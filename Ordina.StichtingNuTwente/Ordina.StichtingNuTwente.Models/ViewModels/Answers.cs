﻿namespace Ordina.StichtingNuTwente.Models.ViewModels
{
    public class Answers
    {
        public string Nummer { get; set; }

        public string Antwoord { get; set; }

    }

    public class AnswersViewModel
    {
        public AnswersViewModel()
        {
            answer = new List<Answers>();
        }
        public List<Answers> answer { get; set; }

        public string Id { get; set; }

        public DateTime AnswerDate { get; set; }

    }
}
