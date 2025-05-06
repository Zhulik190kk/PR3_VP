using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PZ3_VP
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            UsernameTextBox.KeyDown += OnEnterKeyPressed;
            PasswordBox.KeyDown += OnEnterKeyPressed;
        }
        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
{
    if (UsernameTextBox.Text == "Введіть ім’я користувача")
    {
        UsernameTextBox.Text = "";
        UsernameTextBox.Foreground = Brushes.Black;
    }
}

private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
{
    if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
    {
        UsernameTextBox.Text = "Введіть ім’я користувача";
        UsernameTextBox.Foreground = Brushes.Gray;
    }
}

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            CheckLogin();
        }

        private void OnEnterKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                CheckLogin();
        }

        private void CheckLogin()
        {
            bool isUsernameValid = !string.IsNullOrWhiteSpace(UsernameTextBox.Text) &&
                                   UsernameTextBox.Text != "Введіть ім’я користувача";

            bool isPasswordValid = !string.IsNullOrWhiteSpace(PasswordBox.Password);

            if (isUsernameValid && isPasswordValid)
            {
                MessageTextBlock.Text = "Вхід успішний!";
                MessageTextBlock.Foreground = Brushes.Green;
            }
            else
            {
                MessageTextBlock.Text = "Будь ласка, заповніть усі поля.";
                MessageTextBlock.Foreground = Brushes.Red;
            }
        }
    }
}
