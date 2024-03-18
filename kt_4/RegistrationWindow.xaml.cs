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

namespace kt_4
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            SizeToContent = SizeToContent.Manual;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string email = EmailTextBox.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                kt_4Entities context = kt_4Entities.GetContext();

                if (!context.UserExists(username, password))
                {
                    if (context.RegisterUser(username, password, email))
                    {
                        MessageBox.Show("Регистрация успешна!");
                        // Добавьте здесь код для навигации на главную страницу после регистрации
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации. Возможно, такой пользователь уже существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем уже существует. Пожалуйста, выберите другое имя пользователя.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }
    }
}
