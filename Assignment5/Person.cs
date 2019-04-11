using System;

namespace Assignment5
{
    class Person
    {
        string name;
        int age;

        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name 
        {
            get{
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age { get; set; }
    
        static void Main(string[] args)
        {
           
        }

        static void DisplayPeople()
        {
            
        }

    }
}
