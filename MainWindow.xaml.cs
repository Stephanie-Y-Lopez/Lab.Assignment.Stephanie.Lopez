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
            //string number1 = TextBox1.Text;
            //string number2 = TextBox2.Text;
            //string number3 = TextBox3.Text;
            //string number4 = TextBox4.Text;
            //int num1 = int.Parse(number1);
            //int num2 = int.Parse(number2);
            //int num3 = int.Parse(number3);
            //int num4 = int.Parse(number4);
            //string equation = Result1 + Result2 / 2;
            string result1 = Result1.Content.ToString();
            string result2 = Result2.Content.ToString();

            int num1 = int.Parse(result1);
            int num2 = int.Parse(result2);
            int number = 10;

            // Concatenating = ADD STRINGS TOGETHER
            // 2 ints : 1 + 1 = 2
            // 2 string : "1" + "1" = "11"
            // "cat" + "dog" = "catdog"

            // int, short, long = integers = WHOLE NUMBERS
            // float, double, decimal = Floating point = NUMBERS WITH DECIMAL POINTS

            // 5 + 5 / 5 != 2
            // 5 + 1 = 6

            // (5 + 5) / 2 = 2


            double equation =  (num1 + num2)  / 2;
            //string e2 = ((num1 + num2) / 2).ToString();

            Result3.Content = equation;

            // pemdas (perethesis exponents mutiplication divsion add subtract)

            // Result3.Content = equation;
        }
    }
}
