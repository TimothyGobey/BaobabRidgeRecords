namespace BaobabRidgeRecords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            txtRecoveryScore = new TextBox();
            lblCalculatedStatus = new Label();
            lblCalculatedHousing = new Label();
            btnAdd = new Button();
            btnSave = new Button();
            btnClear = new Button();
            txtSearchID = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            dgvAnimals = new DataGridView();
            btnGenerateSummary = new Button();
            lblSummaryTotal = new Label();
            lblSummaryAvgAge = new Label();
            lblSummaryAvgScore = new Label();
            lblCountCritical = new Label();
            lblCountSerious = new Label();
            lblCountStable = new Label();
            lblCountRecovering = new Label();
            lblCountReleaseReady = new Label();
            grpAnimalDetails = new GroupBox();
            grpSearchActions = new GroupBox();
            grpSummaryReport = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpAnimalDetails.SuspendLayout();
            grpSearchActions.SuspendLayout();
            grpSummaryReport.SuspendLayout();
            SuspendLayout();
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(192, 28);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(100, 23);
            txtAnimalID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(192, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(192, 86);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(100, 23);
            txtSpecies.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(192, 117);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 3;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(192, 146);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(100, 23);
            txtRecoveryScore.TabIndex = 4;
            // 
            // lblCalculatedStatus
            // 
            lblCalculatedStatus.AutoSize = true;
            lblCalculatedStatus.Location = new Point(192, 184);
            lblCalculatedStatus.Name = "lblCalculatedStatus";
            lblCalculatedStatus.Size = new Size(95, 15);
            lblCalculatedStatus.TabIndex = 5;
            lblCalculatedStatus.Text = "CalculatedStatus";
            // 
            // lblCalculatedHousing
            // 
            lblCalculatedHousing.AutoSize = true;
            lblCalculatedHousing.Location = new Point(192, 216);
            lblCalculatedHousing.Name = "lblCalculatedHousing";
            lblCalculatedHousing.Size = new Size(108, 15);
            lblCalculatedHousing.TabIndex = 6;
            lblCalculatedHousing.Text = "CalculatedHousing";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 250);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(124, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(217, 250);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(25, 19);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(351, 23);
            txtSearchID.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(463, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search ID";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(463, 58);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected Animal";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(25, 119);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(598, 194);
            dgvAnimals.TabIndex = 13;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(20, 59);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(75, 23);
            btnGenerateSummary.TabIndex = 14;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            // 
            // lblSummaryTotal
            // 
            lblSummaryTotal.AutoSize = true;
            lblSummaryTotal.Location = new Point(42, 112);
            lblSummaryTotal.Name = "lblSummaryTotal";
            lblSummaryTotal.Size = new Size(38, 15);
            lblSummaryTotal.TabIndex = 15;
            lblSummaryTotal.Text = "label1";
            // 
            // lblSummaryAvgAge
            // 
            lblSummaryAvgAge.AutoSize = true;
            lblSummaryAvgAge.Location = new Point(151, 112);
            lblSummaryAvgAge.Name = "lblSummaryAvgAge";
            lblSummaryAvgAge.Size = new Size(38, 15);
            lblSummaryAvgAge.TabIndex = 16;
            lblSummaryAvgAge.Text = "label2";
            // 
            // lblSummaryAvgScore
            // 
            lblSummaryAvgScore.AutoSize = true;
            lblSummaryAvgScore.Location = new Point(266, 112);
            lblSummaryAvgScore.Name = "lblSummaryAvgScore";
            lblSummaryAvgScore.Size = new Size(38, 15);
            lblSummaryAvgScore.TabIndex = 17;
            lblSummaryAvgScore.Text = "label3";
            // 
            // lblCountCritical
            // 
            lblCountCritical.AutoSize = true;
            lblCountCritical.Location = new Point(42, 155);
            lblCountCritical.Name = "lblCountCritical";
            lblCountCritical.Size = new Size(38, 15);
            lblCountCritical.TabIndex = 18;
            lblCountCritical.Text = "label1";
            // 
            // lblCountSerious
            // 
            lblCountSerious.AutoSize = true;
            lblCountSerious.Location = new Point(151, 155);
            lblCountSerious.Name = "lblCountSerious";
            lblCountSerious.Size = new Size(38, 15);
            lblCountSerious.TabIndex = 19;
            lblCountSerious.Text = "label2";
            // 
            // lblCountStable
            // 
            lblCountStable.AutoSize = true;
            lblCountStable.Location = new Point(266, 155);
            lblCountStable.Name = "lblCountStable";
            lblCountStable.Size = new Size(38, 15);
            lblCountStable.TabIndex = 20;
            lblCountStable.Text = "label3";
            // 
            // lblCountRecovering
            // 
            lblCountRecovering.AutoSize = true;
            lblCountRecovering.Location = new Point(42, 193);
            lblCountRecovering.Name = "lblCountRecovering";
            lblCountRecovering.Size = new Size(38, 15);
            lblCountRecovering.TabIndex = 21;
            lblCountRecovering.Text = "label4";
            // 
            // lblCountReleaseReady
            // 
            lblCountReleaseReady.AutoSize = true;
            lblCountReleaseReady.Location = new Point(151, 193);
            lblCountReleaseReady.Name = "lblCountReleaseReady";
            lblCountReleaseReady.Size = new Size(38, 15);
            lblCountReleaseReady.TabIndex = 22;
            lblCountReleaseReady.Text = "label5";
            // 
            // grpAnimalDetails
            // 
            grpAnimalDetails.Controls.Add(txtName);
            grpAnimalDetails.Controls.Add(txtRecoveryScore);
            grpAnimalDetails.Controls.Add(txtAnimalID);
            grpAnimalDetails.Controls.Add(btnClear);
            grpAnimalDetails.Controls.Add(btnSave);
            grpAnimalDetails.Controls.Add(txtSpecies);
            grpAnimalDetails.Controls.Add(btnAdd);
            grpAnimalDetails.Controls.Add(lblCalculatedHousing);
            grpAnimalDetails.Controls.Add(txtAge);
            grpAnimalDetails.Controls.Add(lblCalculatedStatus);
            grpAnimalDetails.Location = new Point(25, 24);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Size = new Size(564, 330);
            grpAnimalDetails.TabIndex = 23;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            grpAnimalDetails.Enter += grpAnimalDetails_Enter;
            // 
            // grpSearchActions
            // 
            grpSearchActions.Controls.Add(dgvAnimals);
            grpSearchActions.Controls.Add(txtSearchID);
            grpSearchActions.Controls.Add(btnSearch);
            grpSearchActions.Controls.Add(btnDelete);
            grpSearchActions.Location = new Point(663, 24);
            grpSearchActions.Name = "grpSearchActions";
            grpSearchActions.Size = new Size(705, 330);
            grpSearchActions.TabIndex = 10;
            grpSearchActions.TabStop = false;
            grpSearchActions.Text = "Search Actions";
            // 
            // grpSummaryReport
            // 
            grpSummaryReport.Controls.Add(lblSummaryAvgScore);
            grpSummaryReport.Controls.Add(btnGenerateSummary);
            grpSummaryReport.Controls.Add(lblSummaryTotal);
            grpSummaryReport.Controls.Add(lblCountReleaseReady);
            grpSummaryReport.Controls.Add(lblSummaryAvgAge);
            grpSummaryReport.Controls.Add(lblCountRecovering);
            grpSummaryReport.Controls.Add(lblCountCritical);
            grpSummaryReport.Controls.Add(lblCountStable);
            grpSummaryReport.Controls.Add(lblCountSerious);
            grpSummaryReport.Location = new Point(25, 386);
            grpSummaryReport.Name = "grpSummaryReport";
            grpSummaryReport.Size = new Size(1343, 262);
            grpSummaryReport.TabIndex = 24;
            grpSummaryReport.TabStop = false;
            grpSummaryReport.Text = "Summary Report";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 660);
            Controls.Add(grpSummaryReport);
            Controls.Add(grpSearchActions);
            Controls.Add(grpAnimalDetails);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpAnimalDetails.ResumeLayout(false);
            grpAnimalDetails.PerformLayout();
            grpSearchActions.ResumeLayout(false);
            grpSearchActions.PerformLayout();
            grpSummaryReport.ResumeLayout(false);
            grpSummaryReport.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtAnimalID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private TextBox txtRecoveryScore;
        private Label lblCalculatedStatus;
        private Label lblCalculatedHousing;
        private Button btnAdd;
        private Button btnSave;
        private Button btnClear;
        private TextBox txtSearchID;
        private Button btnSearch;
        private Button btnDelete;
        private DataGridView dgvAnimals;
        private Button btnGenerateSummary;
        private Label lblSummaryTotal;
        private Label lblSummaryAvgAge;
        private Label lblSummaryAvgScore;
        private Label lblCountCritical;
        private Label lblCountSerious;
        private Label lblCountStable;
        private Label lblCountRecovering;
        private Label lblCountReleaseReady;
        private GroupBox grpAnimalDetails;
        private GroupBox grpSearchActions;
        private GroupBox grpSummaryReport;
    }
}
