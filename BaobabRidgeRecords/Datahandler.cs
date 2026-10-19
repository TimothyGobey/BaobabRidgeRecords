using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;




namespace BaobabRidgeRecords
{
    public class DataHandler

    {
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

        // Checks the file for an existing ID and appends the new animal record.
        public bool AddAnimalRecord(Animal animal, out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                {
                    bool hasLines = false;
                    using (StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8, true, 1024, true))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            hasLines = true;
                            string[] fields = line.Split('|');
                            if (string.Equals(fields[0].Trim(), animal.AnimalId.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                errorMessage = "Animal ID already exists. Please use a different Animal ID.";
                                return false;
                            }
                        }
                    }

                    bool needsNewLine = false;
                    if (hasLines && stream.Length > 0)
                    {
                        stream.Seek(-1, SeekOrigin.End);
                        int lastCharacter = stream.ReadByte();
                        needsNewLine = lastCharacter != '\n' && lastCharacter != '\r';
                    }

                    stream.Seek(0, SeekOrigin.End);
                    using (StreamWriter writer = new StreamWriter(stream, new System.Text.UTF8Encoding(false)))
                    {
                        // Separate the new record if the previous line has no line ending.
                        if (needsNewLine)
                        {
                            writer.WriteLine();
                        }
                        writer.WriteLine(animal.ToFileString());
                    }
                }
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                errorMessage = "You do not have permission to add an animal to animals.txt. Check that the file is not read-only.";
                return false;
            }
            catch (IOException)
            {
                errorMessage = "The animal could not be added. Make sure animals.txt is available and is not in use by another program.";
                return false;
            }
        }

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

        public static bool DeleteAnimalRecord(List<Animal> animalList, Animal animalToDelete)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");
            List<string> lines = new List<string>();

            // Build the remaining lines
            foreach (Animal a in animalList)
            {
                if (a != animalToDelete)
                {
                    lines.Add($"{a.AnimalId}|{a.Name}|{a.Species}|{a.Age}|{a.RecoveryScore}|{a.Status}|{a.HousingUnit}");
                }
            }

            try

            {
                System.IO.File.WriteAllLines(filePath, lines);
                return true;
            }



            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to update animals.txt.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("animals.txt is in use by another program or cannot be written.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ProcessSummaryReport(out int totalAnimals
            , out string avgAgeDisplay
            , out string avgScoreDisplay
            , out int criticalCount
            , out int seriousCount
            , out int stableCount
            , out int recoveringCount
            , out int releaseReadyCount)
        {



            // Initialize outputs
            totalAnimals = 0; 
            criticalCount = 0; 
            seriousCount = 0;
            stableCount = 0;
            recoveringCount = 0; 
            releaseReadyCount = 0;
            avgAgeDisplay = "N/A"; 
            avgScoreDisplay = "N/A";

            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

            string summaryPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "summary.txt");
            double totalAge = 0;
            double totalScore = 0;

            try
            {
                // Read and calculate
                if (System.IO.File.Exists(filePath))
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] parts = line.Split('|');
                        if (parts.Length == 7 && int.TryParse(parts[3].Trim(), out int age) && int.TryParse(parts[4].Trim(), out int score))
                        {
                            totalAnimals++;
                            totalAge += age;
                            totalScore += score;

                            string status = parts[5].Trim();
                            if (status == "Critical") criticalCount++;
                            else if (status == "Serious") seriousCount++;
                            else if (status == "Stable") stableCount++;
                            else if (status == "Recovering") recoveringCount++;
                            else if (status == "Release-Ready") releaseReadyCount++;
                        }
                    }
                }





                // Format averages
                if (totalAnimals > 0)
                {
                    avgAgeDisplay = (totalAge / totalAnimals).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                    avgScoreDisplay = (totalScore / totalAnimals).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                }






                // Write summary file
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(summaryPath, false))
                {
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    writer.WriteLine("BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE");
                    writer.WriteLine("ANIMAL SUMMARY REPORT");
                    writer.WriteLine($"Generated: {timestamp}");
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine($"Total animals:          {totalAnimals}");
                    writer.WriteLine($"Average age (years):    {avgAgeDisplay}");
                    writer.WriteLine($"Average recovery score: {avgScoreDisplay}");
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("Animals per status:");
                    writer.WriteLine($"  Critical:             {criticalCount}");
                    writer.WriteLine($"  Serious:              {seriousCount}");
                    writer.WriteLine($"  Stable:               {stableCount}");
                    writer.WriteLine($"  Recovering:           {recoveringCount}");
                    writer.WriteLine($"  Release-Ready:        {releaseReadyCount}");
                }
                return true;
            }



            catch (Exception ex) 
            when 
            (ex is UnauthorizedAccessException || ex is IOException)
            {
                MessageBox.Show("File access error. Make sure the files are not open in another program.");
                return false;
            }
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