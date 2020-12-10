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
using System.Diagnostics;

namespace Exam1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Arr();
        }

        public void Arr()
        {
            Array myArray = new Array(Convert.ToInt32(arr.Text.Length));
            myArray.Arr = arr.Text.Split(' ').Select(int.Parse).ToArray();
            Debug.WriteLine(myArray.Arr[0]);
           
        }

        private void ref_Click(object sender, RoutedEventArgs e)
        {
            int Sum = 0;
            int Avrg = 0;
            Sum += int.Parse(arr.Text);
            sum.Text = Convert.ToString(Sum);
            Avrg = Convert.ToInt32(Sum) / arr.Text.Length;
            avg.Text = Convert.ToString(Avrg);
            Array myArray = new Array(Convert.ToInt32(arr.Text.Length));
            for (int j = 0; j < arr.Text.Length - 1; j++)
            {
                max.Text = Convert.ToString(arr.Text.Max());
                min.Text = Convert.ToString(arr.Text.Min());
                if (arr.Text[j] % 2 != 0)
                {
                    oddNum.Text = Convert.ToString(arr.Text[j]);
                }
            }
        }
    }
}
