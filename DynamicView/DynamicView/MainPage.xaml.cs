using DynamicView.Models;
using DynamicView.Pages;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DynamicView
{
    public partial class MainPage : ContentPage
    {
        private List<Question> questions;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GenerateQuestion();
        }

        public void GenerateQuestion()
        {
            // Clear data
            questions = new List<Question>();

            Question question1 = new Question();
            question1.Id = 1;
            question1.Detail = "Are you smoking ?";
            question1.IsYesNoQuestion = true;
            questions.Add(question1);

            Question question2 = new Question();
            question2.Id = 2;
            question2.Detail = "What is the reason ?";
            question2.IsDescriptionQuestion = true;
            questions.Add(question2);

            Question question3 = new Question();
            question3.Id = 3;
            question3.Detail = "Do you want to stop smoking ?";
            question3.IsYesNoQuestion = true;
            questions.Add(question3);

            Question question4 = new Question();
            question4.Id = 4;
            question4.Detail = "When will you stop smoking ?";
            question4.IsDescriptionQuestion = true;
            questions.Add(question4);

            Question question5 = new Question();
            question5.Id = 5;
            question5.Detail = "How often do you smoking ?";
            question5.IsSelectionQuestion = true;

            for (int i = 1; i < 3; i++)
            {
                question5.SelectionItem.Add(i + " times a day");
            }

            questions.Add(question5);

            OnPropertyChanged(nameof(questions));
            ListViewQuestion.ItemsSource = questions;
        }

        private async void ButtonSubmit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListAnswerPage(questions));
        }
    }
}
