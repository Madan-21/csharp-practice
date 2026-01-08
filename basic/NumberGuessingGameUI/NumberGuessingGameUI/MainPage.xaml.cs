using System;
using Microsoft.Maui.Controls;

namespace NumberGuessingGameUI
{
    public partial class MainPage : ContentPage
    {
        // Your original variables from console code
        private int counter = 0;
        private Random random = new Random();
        private int number;

        public MainPage()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            counter = 0;
            number = random.Next(1, 101);
            messageDisplay.Text = "Game started! Make your first guess.\n";
            triesLabel.Text = "Tries: 0";
            numberInput.Text = "";
            numberInput.IsEnabled = true;
            guessButton.IsEnabled = true;
            playAgainButton.IsVisible = false;
            numberInput.Focus();
        }

        private void OnGuessClicked(object sender, EventArgs e)
        {
            string input = numberInput.Text;
            int chosenNumber;

            if (!int.TryParse(input, out chosenNumber))
            {
                messageDisplay.Text += "Invalid input, try again.\n";
                numberInput.Text = "";
                return;
            }

            counter++;
            triesLabel.Text = $"Tries: {counter}";

            if (chosenNumber == number)
            {
                messageDisplay.Text += $"\nCongratulations! You guessed it in {counter} tries.\n";
                messageDisplay.Text += "Click 'Play Again' to start a new game.\n";
                numberInput.IsEnabled = false;
                guessButton.IsEnabled = false;
                playAgainButton.IsVisible = true;
            }
            else if (chosenNumber < number)
            {
                messageDisplay.Text += $"You guessed {chosenNumber} - The number is too low.\n";
            }
            else
            {
                messageDisplay.Text += $"You guessed {chosenNumber} - The number is too high.\n";
            }

            numberInput.Text = "";
            numberInput.Focus();
        }

        private void OnPlayAgainClicked(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}