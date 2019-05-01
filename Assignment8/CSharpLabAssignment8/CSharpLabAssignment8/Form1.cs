using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using SharpTrooper.Core;
using Newtonsoft.Json;
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

        private String getIdForRequestedPerson(HttpResponseMessage response)
        {
            String userInput = userInputBox.Text;

            var jsonResponse = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("RESPONSE " + jsonResponse);
            var jsonObject = JObject.Parse(jsonResponse);
            var urlForPerson = jsonObject["results"][0]["url"].ToString();

            Console.WriteLine("adadsfaasdf" + urlForPerson.Length);
            String id = Regex.Match(urlForPerson, @"\d+").Value;



            Console.WriteLine("ID FOR " + userInput + ":" + " " + id);
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

            Console.WriteLine(person.name);

            putOutputToScreen(person);
          
        }

        public void putOutputToScreen(People person)
        {

            SharpTrooperCore core = new SharpTrooperCore();

            nameOutputBox.Text = person.name;
            heightOutputBox.Text = person.height;
            massOutputBox.Text = person.mass;
            hairColorOutputBox.Text = person.hair_color;
            skinColorOutputBox.Text = person.skin_color;
            eyeColorOutputBox.Text = person.eye_color;
            birthYearOutputBox.Text = person.birth_year;
            genderOutputBox.Text = person.gender;

            foreach(String film in person.films)
            {
                String filmID = Regex.Match(film, @"\d+").Value;
                Film filmObject = core.GetFilm(filmID);


            }

        }

    }
}
