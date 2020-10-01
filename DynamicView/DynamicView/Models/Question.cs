using System.Collections.Generic;

namespace DynamicView.Models
{
    public class Question
    {
        public Question()
        {
            SelectionItem = new List<string>();
        }

        public int Id { get; set; }

        // Question types
        public bool IsYesNoQuestion { get; set; }
        public bool IsSelectionQuestion { get; set; }
        public bool IsDescriptionQuestion { get; set; }

        public string Detail { get; set; }
        public List<string> SelectionItem { get; set; }

        // Answer types
        public bool IsYesAnswer { get; set; }
        public string YesAnswer
        {
            get
            {
                return IsYesAnswer ? "Yes" : "No";
            }
        }

        public string SelectedAnswer { get; set; }
        public string DescriptionAnswer { get; set; }

    }
}
