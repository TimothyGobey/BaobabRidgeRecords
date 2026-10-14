using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BaobabRidgeRecords
{
    public partial class Form1 : Form
    {
        private List<Animal> animalList = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
            LoadAnimalsFromFile();
        }

        private void grpAnimalDetails_Enter(object sender, EventArgs e)
        {

        }

        private void LoadAnimalsFromFile()
        {
            string filePath = "animals.txt";

            if (!File.Exists(filePath))
            {
                return;
            }

            animalList.Clear();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split('|');
                if (parts.Length >= 7)
                {
                    string id = parts[0].Trim();
                    string name = parts[1].Trim();
                    string species = parts[2].Trim();
                    int.TryParse(parts[3].Trim(), out int age);
                    int.TryParse(parts[4].Trim(), out int score);
                    string status = parts[5].Trim();
                    string housing = parts[6].Trim();

                    Animal animal = new Animal(id, name, species, age, score, status, housing);
                    animalList.Add(animal);
                }
            }
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            // Check if the animal list is empty
            if (animalList.Count == 0)
            {
                MessageBox.Show("No animal records available to generate summary.", "Summary Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Total Animals
            int totalCount = animalList.Count;

            // 2. Average Age and Average Recovery Score
            double totalAge = 0;
            double totalScore = 0;

            // 3. Status Counters
            int criticalCount = 0;
            int seriousCount = 0;
            int stableCount = 0;
            int recoveringCount = 0;
            int releaseReadyCount = 0;

            // Loop through each animal once to aggregate all values
            foreach (Animal a in animalList)
            {
                totalAge += a.Age;
                totalScore += a.RecoveryScore;

                if (a.Status == "Critical")
                    criticalCount++;
                else if (a.Status == "Serious")
                    seriousCount++;
                else if (a.Status == "Stable")
                    stableCount++;
                else if (a.Status == "Recovering")
                    recoveringCount++;
                else if (a.Status == "Release-Ready")
                    releaseReadyCount++;
            }

            double avgAge = totalAge / totalCount;
            double avgScore = totalScore / totalCount;

            // 4. Update the labels on the screen
            lblSummaryTotal.Text = $"Total Animals: {totalCount}";
            lblSummaryAvgAge.Text = $"Avg Age: {avgAge:F1}";
            lblSummaryAvgScore.Text = $"Avg Score: {avgScore:F1}";

            lblCountCritical.Text = $"Critical: {criticalCount}";
            lblCountSerious.Text = $"Serious: {seriousCount}";
            lblCountStable.Text = $"Stable: {stableCount}";
            lblCountRecovering.Text = $"Recovering: {recoveringCount}";
            lblCountReleaseReady.Text = $"Release-Ready: {releaseReadyCount}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchId = txtSearchID.Text.Trim();

            // 1. Check if the user entered an ID
            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter an Animal ID to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Find the animal with that ID
            Animal animalToDelete = null;
            foreach (Animal a in animalList)
            {
                if (a.AnimalId.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                {
                    animalToDelete = a;
                    break;
                }
            }

            // 3. If no matching animal was found
            if (animalToDelete == null)
            {
                MessageBox.Show($"No animal found with ID: {searchId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4. Confirm before deleting
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete {animalToDelete.AnimalId} ({animalToDelete.Name})? This cannot be undone",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // Remove from the list in memory
                animalList.Remove(animalToDelete);

                // Save the updated list back to animals.txt
                List<string> lines = new List<string>();
                foreach (Animal a in animalList)
                {
                    lines.Add($"{a.AnimalId}|{a.Name}|{a.Species}|{a.Age}|{a.RecoveryScore}|{a.Status}|{a.HousingUnit}");
                }
                File.WriteAllLines("animals.txt", lines);

                // Clear the search box and notify user
                txtSearchID.Clear();
                MessageBox.Show("Animal record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}