/*
Project Name: Lab 1: Creating Classes
By: Adam Nordquist
Date: January 24, 2024
Description: creates 2 classes and runs through their methods.
*/
namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creat objects
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Ben", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Relationship r1 = new Relationship("Sister");
            Relationship r2 = new Relationship("Brother");

            //run class methods
            gina.DisplayPersonInfo(gina);

            mike.ToString(mike);

            ian.ChangeFavouritColour("White");
            ian.DisplayPersonInfo(ian);

            mary.GetAgeInTenYears(mary);

            r1.ShowRelationship(gina, mary);
            r2.ShowRelationship(ian, mike);

            //create list
            List<Person> people = new List<Person>();
            people.Add(ian);
            people.Add(gina);
            people.Add(mary);
            people.Add(mike);

            //run additional methods
            Console.WriteLine("Average age is : " + calculateAverage(people));

            double lowest_age = people.Min(p => p.age); //find youngest age and store as a variable
            double highest_age = people.Max(p => p.age); // find oldest age and store as a variable

            var youngest = people.Find(p => p.age == lowest_age).firstName;
            Console.WriteLine("The youngest person is : " + youngest);

            var oldest = people.Find(p => p.age == highest_age).firstName;
            Console.WriteLine("The oldest person is : " + oldest);

            displayMnames(people);

            displayBluenames(people);

            //methods for main program
            static double calculateAverage(List<Person> people)
            {
                double avg = 0;
                foreach (Person person in people)
                {
                    avg += person.age;
                }
                return avg / people.Count;
            }

            static void displayMnames(List<Person> people)
            {
                Console.WriteLine("People whose name starts with M: ");
                foreach (Person person in people)
                {
                    if (person.firstName.ToCharArray().ElementAt(0) == 'M')
                        Console.WriteLine(person.firstName);
                }
            }

            static void displayBluenames(List<Person> people)
            {
                Console.WriteLine("People whose whose favourite colour is blue: ");
                foreach (Person person in people)
                {
                    if (person.favouriteColour == "Blue")
                        Console.WriteLine(person.firstName);
                }
            }
        }
    }
}
