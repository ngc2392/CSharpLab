using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7PartB
{
    public partial class Form1 : Form
    {

        double firstNumber;
        double secondNumber;
        string operation;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {

            getUserInput();
            double answer = firstNumber + secondNumber;
            setAnswer(answer);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            getUserInput();
            double answer = firstNumber - secondNumber;
            setAnswer(answer);
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            getUserInput();
            double answer = firstNumber * secondNumber;
            setAnswer(answer);
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            getUserInput();
            double answer = firstNumber / secondNumber;
            setAnswer(answer);
        }

        private void getUserInput()
        {
            firstNumber = Convert.ToDouble(userInput1.Text);
            secondNumber = Convert.ToDouble(userInput2.Text);
        }

        private void setAnswer(double answer)
        {
            answerBox.Text = Convert.ToString(answer);
        }

    }
}
