
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
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            PopulateGrid();





        }


        private void ConfigureDataGridView()
        {



            dgvAnimals.AutoGenerateColumns = false;
            dgvAnimals.Columns.Clear();
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AnimalId", HeaderText = "Animal ID", Width = 90 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name", Width = 110 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Species", HeaderText = "Species", Width = 130 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Age", HeaderText = "Age", Width = 60 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RecoveryScore", HeaderText = "Recovery Score", Width = 110 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Status", Width = 110 });
            dgvAnimals.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HousingUnit", HeaderText = "Housing Unit", Width = 150 });



        }


        public void PopulateGrid()
        {
            try
            {

                DataHandler handler = new DataHandler();
                List<Animal> animals = handler.ReadAnimals();
                animalList = animals;

                dgvAnimals.DataSource = null;
                dgvAnimals.DataSource = animals;
            }




            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       

        
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");
            string summaryPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "summary.txt");

            int totalAnimals = 0;
            double totalAge = 0;
            double totalScore = 0;

            int criticalCount = 0;
            int seriousCount = 0;
            int stableCount = 0;
            int recoveringCount = 0;
            int releaseReadyCount = 0;

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split('|');
                        if (parts.Length == 7)
                        {
                            if (int.TryParse(parts[3].Trim(), out int age) && int.TryParse(parts[4].Trim(), out int score))
                            {
                                totalAnimals++;
                                totalAge += age;
                                totalScore += score;

                                // Count using the Status already stored in the file
                                string status = parts[5].Trim();
                                if (status == "Critical") criticalCount++;
                                else if (status == "Serious") seriousCount++;
                                else if (status == "Stable") stableCount++;
                                else if (status == "Recovering") recoveringCount++;
                                else if (status == "Release-Ready") releaseReadyCount++;
                            }
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to read animals.txt.");
                return;
            }
            catch (IOException)
            {
                MessageBox.Show("animals.txt is in use by another program or cannot be read.");
                return;
            }

            string avgAgeDisplay;
            string avgScoreDisplay;

            if (totalAnimals > 0)
            {
                double avgAge = totalAge / totalAnimals;
                double avgScore = totalScore / totalAnimals;
                avgAgeDisplay = avgAge.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                avgScoreDisplay = avgScore.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                avgAgeDisplay = "N/A";
                avgScoreDisplay = "N/A";
            }

            lblSummaryTotal.Text = $"Total Animals: {totalAnimals}";
            lblSummaryAvgAge.Text = $"Avg Age: {avgAgeDisplay}";
            lblSummaryAvgScore.Text = $"Avg Score: {avgScoreDisplay}";

            lblCountCritical.Text = $"Critical: {criticalCount}";
            lblCountSerious.Text = $"Serious: {seriousCount}";
            lblCountStable.Text = $"Stable: {stableCount}";
            lblCountRecovering.Text = $"Recovering: {recoveringCount}";
            lblCountReleaseReady.Text = $"Release-Ready: {releaseReadyCount}";

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(summaryPath, false))
                {
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
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to write summary.txt.");
            }
            catch (IOException)
            {
                MessageBox.Show("summary.txt is in use by another program or cannot be written.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Check that a row is selected in the grid
            if (dgvAnimals.CurrentRow == null)
            {
                MessageBox.Show("Please select an animal in the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Column 0 is Animal ID
            string searchId = dgvAnimals.CurrentRow.Cells[0].Value.ToString();

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
                $"Delete {animalToDelete.AnimalId} ({animalToDelete.Name})? This cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // Path matches the AppDomain style used in Summary
                string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

                // Build the lines for every animal except the one being deleted
                List<string> lines = new List<string>();
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

                    // Only remove from memory once the file was saved successfully
                    animalList.Remove(animalToDelete);

                    // Refresh the grid display to remove the deleted row from view
                    dgvAnimals.DataSource = null;
                    dgvAnimals.DataSource = animalList;

                    MessageBox.Show("Animal record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("You do not have permission to update animals.txt.", "Permission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("animals.txt is in use by another program or cannot be written.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}