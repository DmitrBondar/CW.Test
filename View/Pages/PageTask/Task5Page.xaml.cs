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
    public partial class Task5Page : Page
    {
        public Task5Page()
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

        public static bool IsSymmetric(int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void BtnArrayElement_Click(object sender, RoutedEventArgs e)
        {
            ResultElement.Visibility = Visibility.Visible;
            BtnClear.Visibility = Visibility.Visible;


            int n = Convert.ToInt32(TbN.Text);
            int[,] matrix = new int[n, n];
            
            Random random = new();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 9);
                    matrixElement.Text += $"{matrix[i, j]}\t";
                }
                matrixElement.Text += "\n";
            }

            bool isSymmetric = IsSymmetric(matrix);

            if (isSymmetric)
            {
                Result.Text += $"Массив является симметричным \n относительно главной диагонали.\t";
            }
            else
            {
                Result.Text += $"Массив не является симметричным \n относительно главной диагонали.\t";
            }


        }


        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            matrixElement.Text = "";
            Result.Text = "";
        }
    }
}