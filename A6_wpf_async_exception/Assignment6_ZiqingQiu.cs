using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Ziqing_James_Qiu_Lab06_Sec_003
{
    public partial class Assignment6_ZiqingQiu : Form
    {

        //random elements
        private int _arrayLength = 10;

        public Assignment6_ZiqingQiu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //group box 1
        private BigInteger Factorial(BigInteger n)
        {
            if (n <= 1)
            {
                Thread.Sleep(5000);
                return 1;
            }
            else
            {
                return n*Factorial(n - 1);
            }
        }

        private async void btnCalFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger facInput = Convert.ToInt64(txtFactorial.Text);
                lblFactorialResult.Text = "Calculating Factorial " + facInput + " ...";
                // create Task to perform Fibonacci(facInput) calculation in a thread
                Task<BigInteger> factorialTask = Task.Run(() => Factorial(facInput));
                // wait for Task in separate thread to complete
                await factorialTask;
                lblFactorialResult.Text = factorialTask.Result.ToString("0.######E+000");
            }
            catch (Exception)
            {
                MessageBox.Show($"Invalid input {txtFactorial.Text} !!");
            }
        }

        //group box 2
        private delegate bool numPredicate(int number);
        private void btnCheckEvenOdd_Click(object sender, EventArgs e)
        {
            try
            {
                int eoInput = Convert.ToInt32(txtEvenOdd.Text);
                //delegate + lamba  for even
                Func<int, bool> evenPredicate = (int number) => number % 2 == 0;
                //second way for odd
                numPredicate oddPredicate = (int number) => number % 2 == 1;
                if (evenPredicate(eoInput))
                {
                    lblEvenOddResult.Text = eoInput + " is even";
                }
                else
                {
                    lblEvenOddResult.Text = eoInput + "is odd";
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Invalid input {txtEvenOdd.Text} !!");
            }
        }

        //group box 3
        private void btnGenerateValues_Click(object sender, EventArgs e)
        {
            //clear previous display
            lsbNumbers.Items.Clear();
            Random r = new Random();
            //generate random array
            if (rdoInt.Checked)
            {
                for (int idx = 0; idx < _arrayLength; idx++)
                {
                    lsbNumbers.Items.Add(r.Next(10, 99));
                }
            }
            else if (rdoDouble.Checked)
            {
                for (int idx = 0; idx < _arrayLength; idx++)
                {
                    lsbNumbers.Items.Add(Math.Round(r.NextDouble() * (99 - 10) + 10, 2));
                }
            }
            else if (rdoChar.Checked)
            {
                string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";
                for (int idx = 0; idx < _arrayLength; idx++)
                {
                    lsbNumbers.Items.Add(chars[r.Next(0, chars.Length - 1)]);
                }
            }
            else
            {
                MessageBox.Show("Please select an option");
            }
        }

        private int searchTarget<T>(T target, T[] targetArray) where T : IComparable<T>
        {
            int result = -1;
            for (int i = 0; i < _arrayLength; i++)
            {
                if (target.CompareTo(targetArray[i]) == 0)
                {
                    return result = i;
                }
            }
            return result;
        }
        private void btnSearchValue_Click(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            try
            {
                int result = -1;
                if (rdoInt.Checked)
                {
                    int target = Convert.ToInt32(text);
                    result = searchTarget(target, lsbNumbers.Items.Cast<int>().ToArray());
                }
                else if (rdoDouble.Checked)
                {
                    double target = Convert.ToDouble(text);
                    result = searchTarget(target, lsbNumbers.Items.Cast<double>().ToArray());
                }
                else if (rdoChar.Checked)
                {
                    char target = Convert.ToChar(text);
                    result = searchTarget(target, lsbNumbers.Items.Cast<char>().ToArray());
                }
                if (result != -1)
                {
                    MessageBox.Show($"{text} is found at index {result}");
                }
                else
                {
                    MessageBox.Show($"{text} is NOT found..");
                }
 
            }
            catch (Exception)
            {
                MessageBox.Show($"Input data {txtSearch.Text} type incorrect!");
            }
        }

        private void btnDisplayRange_Click(object sender, EventArgs e)
        {
            //clear previous display
            txtOutputLowHigh.Clear();
            //get bounds
            int lowIndex = Convert.ToInt32(txtLowBound.Text);
            int highIndex = Convert.ToInt32(txtHighBound.Text);
            try
            {
                if (lowIndex < 0)
                {
                    throw new ArgumentException("lowIndex is less than 0");
                }

                if (highIndex > _arrayLength - 1)
                {
                    throw new ArgumentException($"highIndex is greather than size of the array {_arrayLength}");
                }

                if (highIndex < lowIndex)
                {
                    throw new ArgumentException("highIndex is lower than lowIndex");
                }
                for (int i = lowIndex; i <= highIndex; i++)
                {
                    txtOutputLowHigh.Text += $"{lsbNumbers.Items[i]} ";
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
