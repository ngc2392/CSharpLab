using System;
using System.Collections.Generic;

namespace Assignment5
{
    class Person
    {
        public delegate bool FilterDelegate(Person p);
        string name;
        int age;


        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int Age { get; private set; }

        public Person(){}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    
        static void Main(string[] args)
        {
            Person p = new Person {
                Name = "Bob",
                Age = 33
            };

            Person p2 = new Person("bob", 15);
            
            Person[] people = new Person[] {p, p2};


            FilterDelegate isChildDelegate = new FilterDelegate(isChild);

            DisplayPeople(people, isChildDelegate);

           
        }

        public List<Person> DisplayPeople(Person[] people, FilterDelegate method)
        {
            List<Person> filteredList = new List<Person>();

            Console.WriteLine("Method name: " + method.Method.Name);

            foreach(var p in people)
            {
                if(method(p) == true)
                    filteredList.Add(p);

            }
            return filteredList;
        }

        public bool isChild(Person p)
        {
            if(p.Age < 18)
                return true;
            else
                return false;
        }

        public bool firstNameOnly(Person p)
        {
            if(p.Name.Contains(" "))
                return false;
            else
                return true;
        }

        public bool firstNameIsPalindrome(Person p)
        {
            string firstName = p.Name;

            for (int i = 0; i < (firstName.Length) / 2; i++)
            {
                if(firstName[i] != firstName[firstName.Length - i - 1])
                    return false;
            }
            return true;
        }


    

        

    }
}
