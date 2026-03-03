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

namespace PR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
       
        private void GreetButton_Click(object sender, RoutedEventArgs e)
        {
            string inputName = Name.Text.Trim();

            if (!string.IsNullOrWhiteSpace(inputName) && inputName != "Введите ваше имя")
            {
                GreetingTextBlock.Text = $"Рад видеть, {inputName}!";
                GreetingTextBlock.FontWeight = FontWeights.Bold;
                GreetingTextBlock.Foreground = Brushes.DarkBlue;
            }
            else
            {
                
                GreetingTextBlock.Text = "Добрый день!";
                GreetingTextBlock.FontWeight = FontWeights.Normal;
                GreetingTextBlock.Foreground = Brushes.Black;
            }

            
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            GreetingTextBlock.Text = "Добрый день!";
            GreetingTextBlock.FontWeight = FontWeights.Normal;
            GreetingTextBlock.Foreground = Brushes.Black;

            GreetButton.IsEnabled = true;
            GreetButton.Content = "Поприветствовать";

            Name.Text = "Введите ваше имя";
        }

        private void Name_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "Введите ваше имя")
                Name.Text = "";
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name.Text))
                Name.Text = "Введите ваше имя";
            
        }
    }
}
