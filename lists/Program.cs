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
            // planetList.ForEach(planet => Console.WriteLine(planet));
            List<string> newPlanetList = new List<string>(){"Neptune", "Uranus"};
            planetList.AddRange(newPlanetList);
            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            rockyPlanets.ForEach(rockyPlanet => Console.WriteLine($"Rocky Planets {rockyPlanet}"));
            planetList.Remove("Pluto");
            // VVV this works on list because they are ordered VVVV
            // planetList.RemoveAt(6);
            planetList.ForEach(planet => Console.WriteLine($"Planets {planet}"));

        
            // List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>(){
            //     new Dictionary<string, string>(){
            //         {"Viking", "Mars"},
            //         {"opportunity", "Mars"},
            //         {"curiosity", "Mars"}
            //     },
            //     new Dictionary<string, string>(){
            //         {"venera", "Venus"},
            //         {"mariner", "Venus"}
            //     }
            // };

            // foreach (string planet in planetList)
            // {
            //     foreach (Dictionary<string, string> probeList in probes){
            //         if(probeList.ContainsValue(planet)){
            //             foreach (KeyValuePair<string, string> probe in probeList)
            //             {
            //                 Console.WriteLine($"{planet}: {probe.Key}");
            //             }
            //         }
            //     }
            // }
        }
    }
}
