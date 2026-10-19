namespace BaobabRidgeRecords
{
    public class Animal
    {
        public string AnimalId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Species { get; set; } = string.Empty;
        public int Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; } = string.Empty;
        public string HousingUnit { get; set; } = string.Empty;

        public Animal() 
        
        { 
        
        
        }

        public Animal(string animalId, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {


            AnimalId = animalId;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
            Status = status;
            HousingUnit = housingUnit;
        }

    




        // Works out the status and housing for both Add and Update.
        public static void CalculateStatusAndHousing(int recoveryScore, out string status, out string housingUnit)
        {
            if (recoveryScore < 0 || recoveryScore > 100)
            {
                throw new System.ArgumentOutOfRangeException(nameof(recoveryScore), "Recovery Score must be between 0 and 100.");
            }

            if (recoveryScore < 20)
            {
                status = "Critical";
                housingUnit = "Intensive Care Unit";
            }
            else if (recoveryScore < 40)
            {
                status = "Serious";
                housingUnit = "High-Dependency Ward";
            }
            else if (recoveryScore < 60)
            {
                status = "Stable";
                housingUnit = "Recovery Ward";
            }
            else if (recoveryScore < 80)
            {
                status = "Recovering";
                housingUnit = "Outdoor Enclosure";
            }
            else
            {
                status = "Release-Ready";
                housingUnit = "Pre-Release Camp";
            }
        }

        public string ToFileString()
        {
           
            
            
            return $"{AnimalId}|{Name}|{Species}|{Age}|{RecoveryScore}|{Status}|{HousingUnit}";
        }
    }
}
