using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Form1 : Form
    {
        public Form1()
        {

        }


        [STAThread]
        public static void Main()
        {
            ApplicationException.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
