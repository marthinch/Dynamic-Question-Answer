using DynamicView.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicView.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListAnswerPage : ContentPage
    {
        private List<Question> questions;

        public ListAnswerPage(List<Question> questions)
        {
            InitializeComponent();

            this.questions = questions;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CollectionViewAnswer.ItemsSource = questions;
        }
    }
}