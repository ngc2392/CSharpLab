﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using SharpTrooper.Core;
using Newtonsoft.Json.Linq;
using SharpTrooper.Entities;
using System.Text.RegularExpressions;

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

        // help with making request https://stackoverflow.com/questions/9620278/how-do-i-make-calls-to-a-rest-api-using-c
        // help with json https://stackoverflow.com/questions/16459155/how-to-access-json-object-in-c-sharp
        private HttpResponseMessage getRequest(String url, String urlParams)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParams).Result;

            if(response.IsSuccessStatusCode)
            {
                return response;
            } else
            {
                return null;
            }
        }

        // Regex: https://stackoverflow.com/questions/4734116/find-and-extract-a-number-from-a-string
        private String getIdForRequestedPerson(HttpResponseMessage response)
        {
            String userInput = userInputBox.Text;
            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            var jsonObject = JObject.Parse(jsonResponse);
            var urlForPerson = jsonObject["results"][0]["url"].ToString();
            String id = Regex.Match(urlForPerson, @"\d+").Value;
            return id;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // get the ID 
            const String URL = "https://swapi.co/api/people/";
            String userInput = userInputBox.Text;
            String urlParameters = "?search=" + userInput;
            Console.WriteLine("API CALL TO " + URL + urlParameters);
            HttpResponseMessage response = getRequest(URL, urlParameters);
            String id = getIdForRequestedPerson(response);
            SharpTrooperCore core = new SharpTrooperCore();
            var person = core.GetPeople(id);
            putOutputToScreen(person);
        }

        public void putOutputToScreen(People person)
        {
            Console.WriteLine("Outputting persons info on screen");

            // clear any text from previous searches
            filmsListView.Items.Clear();
            speciesListView.Items.Clear();
            vehiclesListView.Items.Clear();
            starshipsListView.Items.Clear();

            SharpTrooperCore core = new SharpTrooperCore();

            nameOutputBox.Text = person.name;
            heightOutputBox.Text = person.height;
            massOutputBox.Text = person.mass;
            hairColorOutputBox.Text = person.hair_color;
            skinColorOutputBox.Text = person.skin_color;
            eyeColorOutputBox.Text = person.eye_color;
            birthYearOutputBox.Text = person.birth_year;
            genderOutputBox.Text = person.gender;

            String planetID = Regex.Match(person.homeworld, @"\d+").Value;
            Planet planet = core.GetPlanet(planetID);
            homePlanetOutputBox.Text = planet.name;

            // put the films on the UI
            foreach (String film in person.films)
            {
                String filmID = Regex.Match(film, @"\d+").Value;
                Film tempFilm = core.GetFilm(filmID);
                filmsListView.Items.Add(tempFilm.title);
            }

            // put the species on the UI
            foreach (String speciesLink in person.species)
            {
                String speciesID = Regex.Match(speciesLink, @"\d+").Value;
                Specie tempSpecies = core.GetSpecie(speciesID);
                speciesListView.Items.Add(tempSpecies.name);
            }

            // put the vehicles on the UI
            foreach (String vehicleLink in person.vehicles)
            {
                String vehicleID = Regex.Match(vehicleLink, @"\d+").Value;
                Vehicle tempVehicle = core.GetVehicle(vehicleID);
                vehiclesListView.Items.Add(tempVehicle.name);
            }

            // put the starships on the UI
            foreach (String starshipLink in person.starships)
            {
                String starshipID = Regex.Match(starshipLink, @"\d+").Value;
                Starship tempStarship = core.GetStarship(starshipID);
                starshipsListView.Items.Add(tempStarship.name);
            }

            if(filmsListView.Items.Count == 0)
            {
                filmsListView.Items.Add("NO FILMS");
            }

            if(speciesListView.Items.Count == 0)
            {
                speciesListView.Items.Add("NO SPECIES");
            }

            if(vehiclesListView.Items.Count == 0)
            {
                vehiclesListView.Items.Add("NO VEHICLES");
            }

            if(starshipsListView.Items.Count == 0)
            {
                starshipsListView.Items.Add("NO STARSHIPS");
            }
        }
    }
}
