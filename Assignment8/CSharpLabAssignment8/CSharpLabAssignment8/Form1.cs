using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpTrooper.Core;
using Newtonsoft.Json;


namespace CSharpLabAssignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SharpTrooperCore core = new SharpTrooperCore();
            var planet = core.GetPlanet("1");
            Console.WriteLine(planet.name);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String userInput = userInputBox.Text;
            SharpTrooperCore core = new SharpTrooperCore();
            var people = core.GetAllPeople();

            Console.WriteLine(people.results.Count);
            
            foreach(var p in people.results)
            {
                Console.WriteLine(p.name);
            }
            
        }
    }
}
