using System;
using System.CodeDom.Compiler;
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

namespace Lab.Assignment.Stephanie.Lopez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string number1 = TextBox1.Text;
            string number2 = TextBox2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            int result = num1 + num2;
            string equation = result.ToString();
            Result1.Content = equation;
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            string number1 = TextBox1.Text;
            string number2 = TextBox2.Text;
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            int result = num1 - num2;
            string equation = result.ToString();
            Result1.Content = equation;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            string number3 = TextBox3.Text;
            string number4 = TextBox4.Text;
            int num1 = int.Parse(number3);
            int num2 = int.Parse(number4);
            int result = num1 * num2;
            string equation = result.ToString();
            Result2.Content = equation;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            string number3 = TextBox3.Text;
            string number4 = TextBox4.Text;
            int num1 = int.Parse(number3);
            int num2 = int.Parse(number4);
            int result = num1 / num2;
            string equation = result.ToString();
            Result2.Content = equation;
        }

        private void AverageResultBut_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
