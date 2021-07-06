using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isPlayer1Turn { get; set; }
        private int counter { get; set; }
        private bool isWon { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "TicTacToe";
            NewGame();
        }
        

        public void NewGame()
        {
            counter = 0;
            isPlayer1Turn = false;
            turnBlock.Text = isPlayer1Turn ? "O" : "X";
            isWon = false;
            turnLabel.Content = "Turn";

            //buttons name pattern: button_row_col
            button_0_0.Content = string.Empty;
            button_1_0.Content = string.Empty;
            button_2_0.Content = string.Empty;
            button_0_1.Content = string.Empty;
            button_1_1.Content = string.Empty;
            button_2_1.Content = string.Empty;
            button_0_2.Content = string.Empty;
            button_1_2.Content = string.Empty;
            button_2_2.Content = string.Empty;

            button_0_0.ClearValue(Button.BackgroundProperty);
            button_1_0.ClearValue(Button.BackgroundProperty);
            button_2_0.ClearValue(Button.BackgroundProperty);
            button_0_1.ClearValue(Button.BackgroundProperty);
            button_1_1.ClearValue(Button.BackgroundProperty);
            button_2_1.ClearValue(Button.BackgroundProperty);
            button_0_2.ClearValue(Button.BackgroundProperty);
            button_1_2.ClearValue(Button.BackgroundProperty);
            button_2_2.ClearValue(Button.BackgroundProperty);
        }


        public void checkIfWon()
        {

            if (counter == 9)
            {
                turnLabel.Content = "Draw";
                turnBlock.Text = "";
            }

            //row 1 
            if (button_0_0.Content != string.Empty && button_0_0.Content ==  button_0_1.Content && button_0_1.Content ==  button_0_2.Content) 
            {
                button_0_0.Background = Brushes.Green; button_0_1.Background = Brushes.Green; button_0_2.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            //row 2 
            }
            if (button_1_0.Content != string.Empty && button_1_0.Content == button_1_1.Content && button_1_1.Content == button_1_2.Content)
            {
                button_1_0.Background = Brushes.Green; button_1_1.Background = Brushes.Green; button_1_2.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
            //row 3
            if (button_2_0.Content != string.Empty && button_2_0.Content == button_2_1.Content && button_2_1.Content == button_2_2.Content)
            {
                button_2_0.Background = Brushes.Green; button_2_1.Background = Brushes.Green; button_2_2.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
            //col 1
            if (button_0_0.Content != string.Empty && button_0_0.Content == button_1_0.Content && button_1_0.Content == button_2_0.Content)
            {
                button_0_0.Background = Brushes.Green; button_1_0.Background = Brushes.Green; button_2_0.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
                //col 2
            }
            if (button_0_1.Content != string.Empty && button_0_1.Content == button_1_1.Content && button_1_1.Content == button_2_1.Content)
            {
                button_0_1.Background = Brushes.Green; button_1_1.Background = Brushes.Green; button_2_1.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
            //col 3
            if (button_0_2.Content != string.Empty && button_0_2.Content == button_1_2.Content && button_1_2.Content == button_2_2.Content)
            {
                button_0_2.Background = Brushes.Green; button_1_2.Background = Brushes.Green; button_2_2.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
            //left diagonal
            if (button_0_0.Content != string.Empty && button_0_0.Content == button_1_1.Content && button_1_1.Content == button_2_2.Content)
            {
                button_0_0.Background = Brushes.Green; button_1_1.Background = Brushes.Green; button_2_2.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
            //right diagonal
            if (button_0_2.Content != string.Empty && button_0_2.Content == button_1_1.Content && button_1_1.Content == button_2_0.Content)
            {
                button_0_2.Background = Brushes.Green; button_1_1.Background = Brushes.Green; button_2_0.Background = Brushes.Green;
                isWon = true;
                turnLabel.Content = "Win";
                turnBlock.Text = isPlayer1Turn ? "X" : "O";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var whichButton = sender as Button;

            
            

            if(whichButton.Content != string.Empty || isWon==true)
            {
                counter += 0;
                whichButton.Content += string.Empty;
            }
                

            else
            {
                counter++;
                if (isPlayer1Turn)
                {
                    isPlayer1Turn = false;
                }
                else
                    isPlayer1Turn = true;

                whichButton.Content = isPlayer1Turn ? "X" : "O";
                turnBlock.Text = isPlayer1Turn ? "O" : "X";
                checkIfWon();
            }
        }

        private void newGameButton_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}
