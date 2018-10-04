using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {

            List<string> Inventory = new List<string> () {
                "Camry",
                "F-150",
                "MDX",
                "Camry",
                "Camry",
                "Taurus",
                "F-150",
                "MDX",
                "Camry",
                "Xterra",
                "Mustang",
                "Suburban",
                "Santa Fe",
                "F-150",
                "Camry",
                "F-150",
                "F-150",
                "Mustang",
                "Camry",
                "Camry",
                "Camry",
                "Escalade",
                "Q30",
                "Camry",
                "MDX",
            };

            HashSet<string> allModels = new HashSet<string> ();

            foreach (string model in Inventory) {
                allModels.Add (model);
            }

            // Display all unique model names
            foreach (string vehicle in allModels) {
                Console.WriteLine ($"{vehicle}");
            }

            /*
                Output

                Camry
                F-150
                MDX
                Taurus
                Xterra
                Mustang
                Suburban
                Santa Fe
                Escalade
                Q30
            */

            // List<string> types = new List<string> () {
            //     "Civic",
            //     "Accord",
            //     "Corolla",
            //     "Kia Sole"
            // };

            HashSet<string> showroom = new HashSet<string> () {
                "Corolla",
                "Kia Sole"
            };

            // foreach (string model in types)
            showroom.Add("Civic");
            showroom.Add("Accord");
            showroom.Add("Accord");
            // showroom.Add("Corolla");
            // showroom.Add("Kia sSole");

            // foreach (string car in showroom){
            // Console.WriteLine($"{car}");
            // }

            Console.WriteLine(showroom.Count);

            HashSet<string> UsedLot = new HashSet<string> ();
            UsedLot.Add("Centra");
            UsedLot.Add("Carlos");

            showroom.UnionWith(UsedLot);
            foreach (string car in showroom){
            Console.WriteLine($"{car}");
            }
            
            showroom.Remove("Centra");
            foreach (string car in showroom){
            Console.WriteLine($"------- Cars after removing one {car}");
            }

            HashSet<string> Junkyard = new HashSet<string> (){
                "car 1",
                "car 2",
                "car 3",
                "Civic",
                "car 4"
            };


            // this finds cars that match from your showroom and junkyard
            HashSet<string> clone = new HashSet<string>(showroom);

            clone.IntersectWith(Junkyard);
            Console.WriteLine("---Cars that match from junkyard to clone---");
            foreach(string car in clone){
                Console.WriteLine($"{car}");
            }

            showroom.UnionWith(Junkyard);
            Console.WriteLine("---Junkyard and showroom mashed---");
             foreach(string car in showroom){
                Console.WriteLine($"{car}");
            }

            showroom.Remove("car 1");
            showroom.Remove("car 3");
            showroom.Remove("Kia Sole");
            Console.WriteLine("---Sold some cars---");
            foreach (string car in showroom){
                Console.WriteLine($"{car}");
            } 
        }
    }
}