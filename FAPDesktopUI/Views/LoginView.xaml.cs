using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FAPDesktopUI.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void TextBlockEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBoxEmail.Focus();
        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxEmail.Text) && TextBoxEmail.Text.Length > 0)
            {
                TextBlockEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockEmail.Visibility = Visibility.Visible;
            }
        }

        private void TextBlockPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextPassword.Focus();
        }

        private void TextPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextPassword.Password) && TextPassword.Password.Length > 0)
            {
                TextBlockPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockPassword.Visibility= Visibility.Visible;
            }
        }
    }
}
