using CW.Test.View.Pages.PageTask;
using CW.Test.Core;
using System.Windows;
using System.Windows.Controls;

namespace CW.Test.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
        }
        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task1Page());
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task2Page());
        }
        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task3Page());
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task4Page());
        }
        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            CoreTest.TestFrame?.Navigate(new Task5Page());
        }
        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите выйти?",
                "Системное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new MainPage());
            }
        }
        
    }
}