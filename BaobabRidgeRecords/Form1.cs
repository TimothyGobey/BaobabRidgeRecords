using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaobabRidgeRecords
{
    public partial class Form1 : Form
    {
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

                dgvAnimals.DataSource = null;
                dgvAnimals.DataSource = animals;
            }




            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);







            }
        }
    }
}