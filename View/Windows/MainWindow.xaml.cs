using CW.Test.Core;
using CW.Test.View.Pages;
using System.Windows;

namespace CW.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreTest.TestFrame = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
        private void Window_MouseleftbuttonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                Application.Current.Shutdown();
            }
        }
    }
}