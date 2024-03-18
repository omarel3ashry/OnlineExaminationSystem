﻿namespace WebAppProject.ViewModels
{
    public class ChoiceViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public ChoiceViewModel()
        {
            Text = string.Empty;
        }
    }
}
