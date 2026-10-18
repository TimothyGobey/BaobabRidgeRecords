using System;
using System.Collections.Generic;
using System.IO;

namespace BaobabRidgeRecords
{
    class DataHandler
    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

        
        public List<Animal> ReadAnimals()
        {
            List<Animal> animalList = new List<Animal>();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
                return animalList; 
            }






            using (StreamReader reader = new StreamReader(filePath))
            {



                string line;
                while ((line = reader.ReadLine()) != null)
                {





                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split('|');






                    if (parts.Length == 7)
                    {
                        
                        string id = parts[0].Trim();
                        string name = parts[1].Trim();
                        string species = parts[2].Trim();
                        int.TryParse(parts[3].Trim(), out int age);
                        int.TryParse(parts[4].Trim(), out int score);
                        string status = parts[5].Trim();
                        string housing = parts[6].Trim();

                        Animal a = new Animal(id, name, species, age, score, status, housing);
                        animalList.Add(a);
                    }


                }



            }
            return animalList; 
        }
    }
}