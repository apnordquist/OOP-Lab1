using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Relationship
    {
        //attributes
        public string relationType;

        //constructor
        public Relationship(string relation)
        {
            relationType = relation;
        }

        public void ShowRelationship(Person p1, Person p2)
        {
            switch(relationType) //compares attribute with permitted values
            {
                case "Brother":
                    Console.WriteLine(p1.firstName + " and " + p2.firstName + " are brothers.");
                    break;
                case "Sister":
                    Console.WriteLine(p1.firstName + " and " + p2.firstName + " are sisters.");
                    break;
                case "Father":
                    Console.WriteLine(p1.firstName + " and " + p2.firstName + " are father and child.");
                    break;
                case "Mother":
                    Console.WriteLine(p1.firstName + " and " + p2.firstName + " are mother abd child");
                    break;
                default:
                    break;
            }
        }
    }
}
