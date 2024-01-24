using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        //attributes
        public int id;
        public string firstName;
        public string lastName;
        public string favouriteColour;
        public int age;
        public bool isWorking;
        //constructor
        public Person(int pId, string first, string last, string colour, int ageYrs, bool working)
        {
            id = pId;
            firstName = first;
            lastName = last;
            favouriteColour = colour;
            age = ageYrs;
            isWorking = working;
        }
        //methods
        public void DisplayPersonInfo(Person p)
        {
            Console.WriteLine(p.firstName p.lastName);
        }
        public void PersonId(Person p)
        {
            Console.WriteLine(p.id);
        }
        public void ChangeFavouritColour(string newColour)
        {
            favouriteColour = newColour;
        }
        public void GetAgeInTenYears(Person p)
        {
            Console.Write(p.age + 10);
        }
        public void ToString(Person p) //display all information as a list
        {
            Console.WriteLine();
        }
     }
}
