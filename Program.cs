using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add() Jupiter and Saturn at the end of the list.
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another List that contains that last two planet of our solar system.
            List<string> lastTwoPlanets = new List<string>(){"Uranus", "Neptune"};
            
            //Combine the two lists by using AddRange().
            planetList.AddRange(lastTwoPlanets);
            
            //int idx = planetList.IndexOf("Mercury");

            //Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            //Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            //Slice the list using GetRange() in order to extract the rocky planets
            // Mercury, Venus, Earth, and Mars into a new list called rockyPlanets.

            List<string> Planets = new List<string>(){"Mercury", "Mars", "Venus", "Earth", "Neptune"};
            List<string> rockyPlanets = planetList.GetRange(0, 3);
            //use the Remove() method to eliminate it from the end of planetList.

            // for each loop to iterate List. 
            foreach (string i in planetList)

            //lists<Dictionary<string, string>> probes = new List<Dictionary<string,string>>();

            {
                
            Console.WriteLine(i);
            }
        }
    }
}
