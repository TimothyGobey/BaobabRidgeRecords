using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BaobabRidgeRecords
{
    public partial class Form1 : Form
    {
        private List<Animal> animalList = new List<Animal>();

        //Stores the record currently selected for editing
        private Animal selectedAnimal;
        public Form1()
        {
            InitializeComponent();

            //Loads a selected grid row into edit mode
            dgvAnimals.CellClick += dgvAnimals_CellClick;
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

        // Checks the input fields before creating a new animal.
        private bool ValidateAnimal(out Animal animal, out string errorMessage, out TextBox invalidField)
        {
            animal = new Animal();
            errorMessage = string.Empty;
            invalidField = txtAnimalID;

            txtAnimalID.Text = txtAnimalID.Text.Trim().ToUpperInvariant();
            txtName.Text = txtName.Text.Trim();
            txtSpecies.Text = txtSpecies.Text.Trim();
            txtAge.Text = txtAge.Text.Trim();
            txtRecoveryScore.Text = txtRecoveryScore.Text.Trim();

            if (!Regex.IsMatch(txtAnimalID.Text, "^WR-[0-9]{4}$"))
            {
                errorMessage = "Animal ID must be WR- followed by exactly four digits, for example WR-0009.";
                return false;
            }

            if (txtName.Text.Length < 1 || txtName.Text.Length > 30 ||
                txtName.Text.Contains('|') || txtName.Text.Contains('\r') || txtName.Text.Contains('\n'))
            {
                invalidField = txtName;
                errorMessage = "Name must contain 1 to 30 characters and cannot contain | or a line break.";
                return false;
            }

            if (txtSpecies.Text.Length < 1 || txtSpecies.Text.Length > 30 ||
                txtSpecies.Text.Contains('|') || txtSpecies.Text.Contains('\r') || txtSpecies.Text.Contains('\n'))
            {
                invalidField = txtSpecies;
                errorMessage = "Species must contain 1 to 30 characters and cannot contain | or a line break.";
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 100)
            {
                invalidField = txtAge;
                errorMessage = "Age must be a whole number between 0 and 100.";
                return false;
            }

            if (!int.TryParse(txtRecoveryScore.Text, out int recoveryScore) || recoveryScore < 0 || recoveryScore > 100)
            {
                invalidField = txtRecoveryScore;
                errorMessage = "Recovery Score must be a whole number between 0 and 100.";
                return false;
            }

            Animal.CalculateStatusAndHousing(recoveryScore, out string status, out string housingUnit);
            animal = new Animal(txtAnimalID.Text, txtName.Text, txtSpecies.Text, age, recoveryScore, status, housingUnit);
            return true;
        }

        // Adds a valid animal to the file, then refreshes the grid for the next entry.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateAnimal(out Animal animal, out string errorMessage, out TextBox invalidField))
            {
                MessageBox.Show(errorMessage, "Invalid Animal Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                invalidField.Focus();
                invalidField.SelectAll();
                return;
            }

            DataHandler handler = new DataHandler();
            if (!handler.AddAnimalRecord(animal, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Add Animal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnimalID.Focus();
                txtAnimalID.SelectAll();
                return;
            }

            PopulateGrid();
            MessageBox.Show($"Animal added successfully.\n\nStatus: {animal.Status}\nHousing Unit: {animal.HousingUnit}",
                "Animal Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAnimalInputs();
        }

        // Shows the calculated details while a valid recovery score is entered.
        private void txtRecoveryScore_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRecoveryScore.Text.Trim(), out int recoveryScore) && recoveryScore >= 0 && recoveryScore <= 100)
            {
                Animal.CalculateStatusAndHousing(recoveryScore, out string status, out string housingUnit);
                lblCalculatedStatus.Text = status;
                lblCalculatedHousing.Text = housingUnit;
            }
            else
            {
                lblCalculatedStatus.Text = "[---]";
                lblCalculatedHousing.Text = "[---]";
            }
        }

        // Empties the animal inputs so another record can be entered.
        private void ClearAnimalInputs()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();
            lblCalculatedStatus.Text = "[---]";
            lblCalculatedHousing.Text = "[---]";
            txtAnimalID.Focus();
        }

        // Clears an unfinished Add entry.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAnimalInputs();
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            // Let DataHandler process the files and math, and hand back the numbers
            bool success = DataHandler.ProcessSummaryReport(
                out int totalAnimals, out string avgAgeDisplay, out string avgScoreDisplay,
                out int criticalCount, out int seriousCount, out int stableCount,
                out int recoveringCount, out int releaseReadyCount);

            if (success)
            {
                // Just update the UI labels
                lblSummaryTotal.Text = totalAnimals.ToString();
                lblSummaryAvgAge.Text = avgAgeDisplay;
                lblSummaryAvgScore.Text = avgScoreDisplay;

                lblCountCritical.Text = criticalCount.ToString();
                lblCountSerious.Text = seriousCount.ToString();
                lblCountStable.Text = stableCount.ToString();
                lblCountRecovering.Text = recoveringCount.ToString();
                lblCountReleaseReady.Text = releaseReadyCount.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. UI Check
            if (dgvAnimals.CurrentRow == null)
            {
                MessageBox.Show("Please select an animal in the grid first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string searchId = dgvAnimals.CurrentRow.Cells[0].Value.ToString();
            Animal animalToDelete = null;

            // 2. Find Animal in memory list
            foreach (Animal a in animalList)
            {
                if (a.AnimalId.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                {
                    animalToDelete = a;
                    break;
                }
            }

            if (animalToDelete == null)
            {
                MessageBox.Show($"No animal found with ID: {searchId}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. UI Confirmation
            DialogResult confirm = MessageBox.Show(
                $"Delete {animalToDelete.AnimalId} ({animalToDelete.Name})? This cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // 4. Pass heavy lifting to the DataHandler
                bool success = DataHandler.DeleteAnimalRecord(animalList, animalToDelete);

                if (success)
                {
                    // Update UI grid
                    animalList.Remove(animalToDelete);
                    dgvAnimals.DataSource = null;
                    dgvAnimals.DataSource = animalList;
                    MessageBox.Show("Animal record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            //Ignore clicks on the column headings
            if (e.RowIndex < 0)
            {
                return;                
            }

            //Gets the Animal object behind the selected row
            selectedAnimal = dgvAnimals.Rows[e.RowIndex].DataBoundItem as Animal;

            if (selectedAnimal == null) 
            {
                return;
            }

            //Shows the selected record in the form for editing
            txtAnimalID.Text = selectedAnimal.AnimalId;
            txtName.Text = selectedAnimal.Name;
            txtSpecies.Text = selectedAnimal.Species;
            txtAge.Text = selectedAnimal.Age.ToString();
            txtRecoveryScore.Text = selectedAnimal.RecoveryScore.ToString();
            lblCalculatedStatus.Text = selectedAnimal.Status;
            lblCalculatedHousing.Text = selectedAnimal.HousingUnit;

            //The ID stays fixed while the user edits the record
            txtAnimalID.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }
    }
}
