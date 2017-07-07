using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetList2);
            planetList.Insert(1, "Mercury");
            planetList.Insert(2, "Venus");  
            planetList.Insert(3, "Earth");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");


            Console.WriteLine();
            foreach(string planet in planetList){
                Console.WriteLine(planet);
            }
            Console.WriteLine();
            foreach(string rockyPlanet in rockyPlanets){
                Console.WriteLine(rockyPlanet);
            }
        }
    }
}
