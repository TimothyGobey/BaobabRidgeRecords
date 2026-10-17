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
            txtAnimalID.Location = new Point(246, 42);
            txtAnimalID.Margin = new Padding(3, 5, 3, 5);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(200, 30);
            txtAnimalID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(246, 87);
            txtName.Margin = new Padding(3, 5, 3, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 30);
            txtName.TabIndex = 1;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(246, 132);
            txtSpecies.Margin = new Padding(3, 5, 3, 5);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(200, 30);
            txtSpecies.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(246, 177);
            txtAge.Margin = new Padding(3, 5, 3, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 30);
            txtAge.TabIndex = 3;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(246, 222);
            txtRecoveryScore.Margin = new Padding(3, 5, 3, 5);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(200, 30);
            txtRecoveryScore.TabIndex = 4;
            // 
            // lblCalculatedStatus
            // 
            lblCalculatedStatus.AutoSize = true;
            lblCalculatedStatus.Location = new Point(246, 282);
            lblCalculatedStatus.Name = "lblCalculatedStatus";
            lblCalculatedStatus.Size = new Size(136, 23);
            lblCalculatedStatus.TabIndex = 5;
            lblCalculatedStatus.Text = "CalculatedStatus";
            // 
            // lblCalculatedHousing
            // 
            lblCalculatedHousing.AutoSize = true;
            lblCalculatedHousing.Location = new Point(246, 332);
            lblCalculatedHousing.Name = "lblCalculatedHousing";
            lblCalculatedHousing.Size = new Size(153, 23);
            lblCalculatedHousing.TabIndex = 6;
            lblCalculatedHousing.Text = "CalculatedHousing";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(30, 30, 30);
            btnAdd.Location = new Point(26, 383);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.FromArgb(30, 30, 30);
            btnSave.Location = new Point(152, 383);
            btnSave.Margin = new Padding(3, 5, 3, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(41, 128, 185);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(30, 30, 30);
            btnClear.Location = new Point(278, 383);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(33, 29);
            txtSearchID.Margin = new Padding(3, 5, 3, 5);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(451, 30);
            txtSearchID.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(30, 30, 30);
            btnSearch.Location = new Point(595, 29);
            btnSearch.Margin = new Padding(3, 5, 3, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 35);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search ID";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 57, 43);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(704, 29);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(97, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected Animal";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(33, 132);
            dgvAnimals.Margin = new Padding(3, 5, 3, 5);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(768, 298);
            dgvAnimals.TabIndex = 13;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.ForestGreen;
            btnGenerateSummary.Cursor = Cursors.Hand;
            btnGenerateSummary.FlatAppearance.BorderSize = 0;
            btnGenerateSummary.FlatStyle = FlatStyle.Flat;
            btnGenerateSummary.ForeColor = Color.White;
            btnGenerateSummary.Location = new Point(54, 52);
            btnGenerateSummary.Margin = new Padding(3, 5, 3, 5);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(97, 35);
            btnGenerateSummary.TabIndex = 14;
            btnGenerateSummary.Text = "Generate Summary\r\n";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // lblSummaryTotal
            // 
            lblSummaryTotal.AutoSize = true;
            lblSummaryTotal.Location = new Point(54, 182);
            lblSummaryTotal.Name = "lblSummaryTotal";
            lblSummaryTotal.Size = new Size(127, 23);
            lblSummaryTotal.TabIndex = 15;
            lblSummaryTotal.Text = "Total Animals: -";
            // 
            // lblSummaryAvgAge
            // 
            lblSummaryAvgAge.AutoSize = true;
            lblSummaryAvgAge.Location = new Point(195, 182);
            lblSummaryAvgAge.Name = "lblSummaryAvgAge";
            lblSummaryAvgAge.Size = new Size(90, 23);
            lblSummaryAvgAge.TabIndex = 16;
            lblSummaryAvgAge.Text = "Avg Age: -";
            // 
            // lblSummaryAvgScore
            // 
            lblSummaryAvgScore.AutoSize = true;
            lblSummaryAvgScore.Location = new Point(358, 182);
            lblSummaryAvgScore.Name = "lblSummaryAvgScore";
            lblSummaryAvgScore.Size = new Size(102, 23);
            lblSummaryAvgScore.TabIndex = 17;
            lblSummaryAvgScore.Text = "Avg Score: -";
            // 
            // lblCountCritical
            // 
            lblCountCritical.AutoSize = true;
            lblCountCritical.Location = new Point(70, 238);
            lblCountCritical.Name = "lblCountCritical";
            lblCountCritical.Size = new Size(80, 23);
            lblCountCritical.TabIndex = 18;
            lblCountCritical.Text = "Critical: 0";
            // 
            // lblCountSerious
            // 
            lblCountSerious.AutoSize = true;
            lblCountSerious.Location = new Point(206, 238);
            lblCountSerious.Name = "lblCountSerious";
            lblCountSerious.Size = new Size(83, 23);
            lblCountSerious.TabIndex = 19;
            lblCountSerious.Text = "Serious: 0";
            // 
            // lblCountStable
            // 
            lblCountStable.AutoSize = true;
            lblCountStable.Location = new Point(371, 238);
            lblCountStable.Name = "lblCountStable";
            lblCountStable.Size = new Size(74, 23);
            lblCountStable.TabIndex = 20;
            lblCountStable.Text = "Stable: 0";
            // 
            // lblCountRecovering
            // 
            lblCountRecovering.AutoSize = true;
            lblCountRecovering.Location = new Point(70, 306);
            lblCountRecovering.Name = "lblCountRecovering";
            lblCountRecovering.Size = new Size(112, 23);
            lblCountRecovering.TabIndex = 21;
            lblCountRecovering.Text = "Recovering: 0";
            // 
            // lblCountReleaseReady
            // 
            lblCountReleaseReady.AutoSize = true;
            lblCountReleaseReady.Location = new Point(206, 306);
            lblCountReleaseReady.Name = "lblCountReleaseReady";
            lblCountReleaseReady.Size = new Size(138, 23);
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
            grpAnimalDetails.Location = new Point(33, 36);
            grpAnimalDetails.Margin = new Padding(3, 5, 3, 5);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Padding = new Padding(3, 5, 3, 5);
            grpAnimalDetails.Size = new Size(726, 506);
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
            grpSearchActions.Location = new Point(853, 36);
            grpSearchActions.Margin = new Padding(3, 5, 3, 5);
            grpSearchActions.Name = "grpSearchActions";
            grpSearchActions.Padding = new Padding(3, 5, 3, 5);
            grpSearchActions.Size = new Size(907, 506);
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
            grpSummaryReport.Location = new Point(33, 552);
            grpSummaryReport.Margin = new Padding(3, 5, 3, 5);
            grpSummaryReport.Name = "grpSummaryReport";
            grpSummaryReport.Padding = new Padding(3, 5, 3, 5);
            grpSummaryReport.Size = new Size(2189, 680);
            grpSummaryReport.TabIndex = 24;
            grpSummaryReport.TabStop = false;
            grpSummaryReport.Text = "Summary Report";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1776, 1012);
            Controls.Add(grpSummaryReport);
            Controls.Add(grpSearchActions);
            Controls.Add(grpAnimalDetails);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
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
