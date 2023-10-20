using System;
using System.Windows;

namespace QuizApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Check answers and provide feedback to the user
            bool question1Correct = Question1Option1.IsChecked == true;  // Berlin
            bool question2Correct = Question2Option3.IsChecked == true;  // Lisbon
            bool question3Correct = Question3Option1.IsChecked == true;  // Brasília

            string feedback = "Quiz Results:\n";
            feedback += "Question 1: " + (question1Correct ? "Correct" : "Incorrect") + "\n";
            feedback += "Question 2: " + (question2Correct ? "Correct" : "Incorrect") + "\n";
            feedback += "Question 3: " + (question3Correct ? "Correct" : "Incorrect") + "\n";

            MessageBox.Show(feedback, "Quiz Results");
        }
    }
}
