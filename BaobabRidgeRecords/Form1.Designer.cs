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
            txtAnimalID.Location = new Point(219, 37);
            txtAnimalID.Margin = new Padding(3, 4, 3, 4);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(114, 27);
            txtAnimalID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 76);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 1;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(219, 115);
            txtSpecies.Margin = new Padding(3, 4, 3, 4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(114, 27);
            txtSpecies.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(219, 156);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(114, 27);
            txtAge.TabIndex = 3;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(219, 195);
            txtRecoveryScore.Margin = new Padding(3, 4, 3, 4);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(114, 27);
            txtRecoveryScore.TabIndex = 4;
            // 
            // lblCalculatedStatus
            // 
            lblCalculatedStatus.AutoSize = true;
            lblCalculatedStatus.Location = new Point(219, 245);
            lblCalculatedStatus.Name = "lblCalculatedStatus";
            lblCalculatedStatus.Size = new Size(119, 20);
            lblCalculatedStatus.TabIndex = 5;
            lblCalculatedStatus.Text = "CalculatedStatus";
            // 
            // lblCalculatedHousing
            // 
            lblCalculatedHousing.AutoSize = true;
            lblCalculatedHousing.Location = new Point(219, 288);
            lblCalculatedHousing.Name = "lblCalculatedHousing";
            lblCalculatedHousing.Size = new Size(134, 20);
            lblCalculatedHousing.TabIndex = 6;
            lblCalculatedHousing.Text = "CalculatedHousing";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 333);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(142, 333);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 333);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(29, 25);
            txtSearchID.Margin = new Padding(3, 4, 3, 4);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(401, 27);
            txtSearchID.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(529, 25);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search ID";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(529, 77);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected Animal";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(29, 159);
            dgvAnimals.Margin = new Padding(3, 4, 3, 4);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(683, 259);
            dgvAnimals.TabIndex = 13;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(48, 45);
            btnGenerateSummary.Margin = new Padding(3, 4, 3, 4);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(86, 31);
            btnGenerateSummary.TabIndex = 14;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // lblSummaryTotal
            // 
            lblSummaryTotal.AutoSize = true;
            lblSummaryTotal.Location = new Point(48, 158);
            lblSummaryTotal.Name = "lblSummaryTotal";
            lblSummaryTotal.Size = new Size(112, 20);
            lblSummaryTotal.TabIndex = 15;
            lblSummaryTotal.Text = "Total Animals: -";
            // 
            // lblSummaryAvgAge
            // 
            lblSummaryAvgAge.AutoSize = true;
            lblSummaryAvgAge.Location = new Point(173, 158);
            lblSummaryAvgAge.Name = "lblSummaryAvgAge";
            lblSummaryAvgAge.Size = new Size(79, 20);
            lblSummaryAvgAge.TabIndex = 16;
            lblSummaryAvgAge.Text = "Avg Age: -";
            // 
            // lblSummaryAvgScore
            // 
            lblSummaryAvgScore.AutoSize = true;
            lblSummaryAvgScore.Location = new Point(318, 158);
            lblSummaryAvgScore.Name = "lblSummaryAvgScore";
            lblSummaryAvgScore.Size = new Size(89, 20);
            lblSummaryAvgScore.TabIndex = 17;
            lblSummaryAvgScore.Text = "Avg Score: -";
            // 
            // lblCountCritical
            // 
            lblCountCritical.AutoSize = true;
            lblCountCritical.Location = new Point(62, 207);
            lblCountCritical.Name = "lblCountCritical";
            lblCountCritical.Size = new Size(70, 20);
            lblCountCritical.TabIndex = 18;
            lblCountCritical.Text = "Critical: 0";
            // 
            // lblCountSerious
            // 
            lblCountSerious.AutoSize = true;
            lblCountSerious.Location = new Point(183, 207);
            lblCountSerious.Name = "lblCountSerious";
            lblCountSerious.Size = new Size(72, 20);
            lblCountSerious.TabIndex = 19;
            lblCountSerious.Text = "Serious: 0";
            // 
            // lblCountStable
            // 
            lblCountStable.AutoSize = true;
            lblCountStable.Location = new Point(330, 207);
            lblCountStable.Name = "lblCountStable";
            lblCountStable.Size = new Size(66, 20);
            lblCountStable.TabIndex = 20;
            lblCountStable.Text = "Stable: 0";
            // 
            // lblCountRecovering
            // 
            lblCountRecovering.AutoSize = true;
            lblCountRecovering.Location = new Point(62, 266);
            lblCountRecovering.Name = "lblCountRecovering";
            lblCountRecovering.Size = new Size(98, 20);
            lblCountRecovering.TabIndex = 21;
            lblCountRecovering.Text = "Recovering: 0";
            // 
            // lblCountReleaseReady
            // 
            lblCountReleaseReady.AutoSize = true;
            lblCountReleaseReady.Location = new Point(183, 266);
            lblCountReleaseReady.Name = "lblCountReleaseReady";
            lblCountReleaseReady.Size = new Size(122, 20);
            lblCountReleaseReady.TabIndex = 22;
            lblCountReleaseReady.Text = "Release-Ready: 0";
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
            grpAnimalDetails.Location = new Point(29, 32);
            grpAnimalDetails.Margin = new Padding(3, 4, 3, 4);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Padding = new Padding(3, 4, 3, 4);
            grpAnimalDetails.Size = new Size(645, 440);
            grpAnimalDetails.TabIndex = 23;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // grpSearchActions
            // 
            grpSearchActions.Controls.Add(dgvAnimals);
            grpSearchActions.Controls.Add(txtSearchID);
            grpSearchActions.Controls.Add(btnSearch);
            grpSearchActions.Controls.Add(btnDelete);
            grpSearchActions.Location = new Point(758, 32);
            grpSearchActions.Margin = new Padding(3, 4, 3, 4);
            grpSearchActions.Name = "grpSearchActions";
            grpSearchActions.Padding = new Padding(3, 4, 3, 4);
            grpSearchActions.Size = new Size(806, 440);
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
            grpSummaryReport.Location = new Point(29, 480);
            grpSummaryReport.Margin = new Padding(3, 4, 3, 4);
            grpSummaryReport.Name = "grpSummaryReport";
            grpSummaryReport.Padding = new Padding(3, 4, 3, 4);
            grpSummaryReport.Size = new Size(1946, 592);
            grpSummaryReport.TabIndex = 24;
            grpSummaryReport.TabStop = false;
            grpSummaryReport.Text = "Summary Report";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 880);
            Controls.Add(grpSummaryReport);
            Controls.Add(grpSearchActions);
            Controls.Add(grpAnimalDetails);
            Margin = new Padding(3, 4, 3, 4);
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
