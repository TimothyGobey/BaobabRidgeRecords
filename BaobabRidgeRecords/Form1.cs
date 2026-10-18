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
    }
}