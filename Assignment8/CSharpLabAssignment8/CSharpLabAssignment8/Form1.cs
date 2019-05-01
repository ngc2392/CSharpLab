﻿using System;
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
using SharpTrooper.Entities;


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


            Console.WriteLine("NEXT" + " " +  people.next);

            foreach(var p in people.results)
            {
                Console.WriteLine("FIRST PAGE");
                Console.WriteLine(p.name);
            }

            var person45 = core.GetPeople("45");
            Console.WriteLine("45" + " " + person45.name);

            var person87 = core.GetPeople("87");
            Console.WriteLine("87" + " " +  person87.name);

            var resourceFromUrl = core.GetSingleByUrl<SharpEntityResults<People>>(people.next);

            foreach (var p in resourceFromUrl.results)
            {
                Console.WriteLine("SECOND PAGE");
                Console.WriteLine(p.name);
            }



            var planet = core.GetPlanet("1");

            var planets = core.GetAllPlanets();

          
        }

    }
}