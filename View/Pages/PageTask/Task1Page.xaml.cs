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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CW.Test.View.Pages.PageTask
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
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


        public static int FindMaxElementInOrderedColumns(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            bool hasOrderedColumns = false;
            int maxElement = 0;

            for (int j = 0; j < cols; j++)
            {
                bool isAscending = true;
                bool isDescending = true;

                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < matrix[i - 1, j])
                    {
                        isAscending = false;
                    }

                    if (matrix[i, j] > matrix[i - 1, j])
                    {
                        isDescending = false;
                    }
                }

                if (isAscending || isDescending)
                {
                    hasOrderedColumns = true;

                    // Находим максимальный элемент в столбце
                    for (int i = 0; i < rows; i++)
                    {
                        int currentElement = matrix[i, j];
                        if (currentElement > maxElement)
                        {
                            maxElement = currentElement;
                        }
                    }
                }
            }

            if (hasOrderedColumns)
            {
                return maxElement;
            }
            else
            {
                return 0;
            }
        }

        

        private void BtnSearchElement_Click(object sender, RoutedEventArgs e)
        {
            SearchElement.Visibility = Visibility.Visible;
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

            int maxElement = FindMaxElementInOrderedColumns(matrix);

            if (maxElement != 0)
            {
                Result.Text += $"{maxElement}\t";
            }
            else
            {
                Result.Text += $"0\t";
            }        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            matrixElement.Text = "";
            Result.Text = "";
        }
    }

}