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
    public partial class Task3Page : Page
    {
        public Task3Page()
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


        int n, m;
        private int[,] matrix = new int[5, 4];



        private void BtnMinElement_Click(object sender, RoutedEventArgs e)
        {
            MinElement.Visibility = Visibility.Visible;
            BtnClear.Visibility = Visibility.Visible;
            
            int n = Convert.ToInt32(TbN.Text);
            int m = Convert.ToInt32(TbM.Text);
            int[,] matrix = new int[n, m];

            Random random = new();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(0, 9);
                    matrixElement.Text += $"{matrix[i, j]}\t";
                }
                matrixElement.Text += "\n";
            }


            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int minElement = matrix[i, 0];
                int minElementIndex = 0;

                // Находим самый левый наименьший элемент в текущей строке
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                        minElementIndex = j;
                    }
                }

                // Переставляем его в первый столбец
                int temp = matrix[i, 0];
                matrix[i, 0] = minElement;
                matrix[i, minElementIndex] = temp;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Result.Text += $"{matrix[i, j]}\t";
                }
                Result.Text += "\n";
            }



        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            matrixElement.Text = "";
            Result.Text = "";
        }

    }
}