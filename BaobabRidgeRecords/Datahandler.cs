using System;
using System.Collections.Generic;
using System.IO;

namespace BaobabRidgeRecords
{
    public class DataHandler
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

        public bool UpdateAnimal(Animal updatedAnimal) 
        {
            //Prevents the program from attempting to update a missing animal
            if (updatedAnimal == null)
            {
                throw new ArgumentNullException(nameof(updatedAnimal)); 
            }

            //Reads the current records before making any changes
            List<Animal> animals = ReadAnimals();

            //Locates the original record by its unique Animal ID
            int animalIndex = animals.FindIndex(a =>
                string.Equals(a.AnimalId, updatedAnimal.AnimalId,
                StringComparison.OrdinalIgnoreCase));

            //Stops the update if the selected ID does not exist in the file
            if (animalIndex == -1)
            {
                return false;
            }

            //Replaces the old record with the edited record
            animals[animalIndex] = updatedAnimal;

            List<string> lines = new List<string>();

            //Converts each animal back to the pipe-seperated format used in animals.txt
            foreach (Animal animal in animals)
            {
                lines.Add(animal.ToFileString()); 
            }

            //Rewrite the file so it contains the edited record
            File.WriteAllLines(filePath, lines);
            return true;
        }
    }
}