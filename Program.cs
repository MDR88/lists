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
            
            // for each loop to iterate List. 
            foreach (string i in planetList)

            {
                
            Console.WriteLine(i);
            }
        }
    }
}
