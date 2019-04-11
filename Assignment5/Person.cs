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

            Person p2 = new Person("Robert", 13);
            Person p3 = new Person("Benjamin", 72);
            Person p4 = new Person("Matt", 17);
            Person p5 = new Person("Reese", 44);

            
            Person[] people = new Person[] {p, p2, p3, p4, p5};


            FilterDelegate isChildDelegate = new FilterDelegate(isChild);

            var filtered = DisplayPeople(people, isChildDelegate);

            foreach (var per in filtered)
            {
                Console.WriteLine(per.Name);
            }

            Console.WriteLine();
            

           
        }

        public static List<Person> DisplayPeople(Person[] people, FilterDelegate method)
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

        public static bool isChild(Person p)
        {
            if(p.Age < 18)
                return true;
            else
                return false;
        }

        public static bool firstNameOnly(Person p)
        {
            if(p.Name.Contains(" "))
                return false;
            else
                return true;
        }

        public static bool firstNameIsPalindrome(Person p)
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
