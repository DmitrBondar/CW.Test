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
    public partial class Task2Page : Page
    {
        public Task2Page()
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


        private void BtnMirrorElement_Click(object sender, RoutedEventArgs e)
        {
            MirrorElement.Visibility = Visibility.Visible;
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
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n)
                    {
                        // Получаем индексы элементов, которые будут зеркально отражены
                        int mirrorI = n - j - 1;
                        int mirrorJ = n - i - 1;

                        // Меняем местами элементы
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[mirrorI, mirrorJ];
                        matrix[mirrorI, mirrorJ] = temp;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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