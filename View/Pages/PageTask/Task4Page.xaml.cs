using CW.Test.Core;
using MaterialDesignThemes.Wpf.Internal;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
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
            if (MessageBox.Show("Вы действительно хотите выйти?",
                "Системное сообщение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CoreTest.TestFrame?.Navigate(new MainPage());
            }
        }


        private void BtnResElement_Click(object sender, RoutedEventArgs e)
        {
            
            BtnClear.Visibility = Visibility.Visible;

            int n = Convert.ToInt32(TbN.Text);
            int[,] matrix = new int[n, n];

            // Заполнение массива в соответствии с правилами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        matrix[i, j] = 1;  // Диагональные элементы равны 1
                    }
                    else if (i + j < n - 1)
                    {
                        matrix[i, j] = 0;  // Элементы выше диагонали равны 0
                    }
                    else
                    {
                        matrix[i, j] = 2;  // Элементы ниже диагонали равны 2
                    }
                }
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixElement.Text += $"{matrix[i, j]}\t";
                }
                matrixElement.Text += "\n";
            }



        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            matrixElement.Text = "";
            
        }

    }
}