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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            pictureBox1 = new PictureBox();
            lblHousingStatic = new Label();
            lblStatusStatic = new Label();
            lblRecoveryScoreStatic = new Label();
            lblAgeStatic = new Label();
            lblSpeciesStatic = new Label();
            lblNameStatic = new Label();
            lblAnimalIDStatic = new Label();
            grpSearchActions = new GroupBox();
            grpSummaryReport = new GroupBox();
            lblReadyReleaseCount = new Label();
            lblRecoveringCountStatic = new Label();
            lblSeriousCountStatic = new Label();
            lblStableCountStatic = new Label();
            lblCriticalCountStatic = new Label();
            lblSummaryAverageScoreStatic = new Label();
            lblSummaryAvgAgeStatic = new Label();
            lblSummaryTotalStatic = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            grpAnimalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpSearchActions.SuspendLayout();
            grpSummaryReport.SuspendLayout();
            SuspendLayout();
            // 
            // txtAnimalID
            // 
            txtAnimalID.Font = new Font("Segoe UI", 11.25F);
            txtAnimalID.Location = new Point(156, 31);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(100, 27);
            txtAnimalID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 11.25F);
            txtName.Location = new Point(156, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 27);
            txtName.TabIndex = 1;
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI", 11.25F);
            txtSpecies.Location = new Point(156, 89);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(100, 27);
            txtSpecies.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 11.25F);
            txtAge.Location = new Point(156, 119);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 27);
            txtAge.TabIndex = 3;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Font = new Font("Segoe UI", 11.25F);
            txtRecoveryScore.Location = new Point(156, 148);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(100, 27);
            txtRecoveryScore.TabIndex = 4;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;
            // 
            // lblCalculatedStatus
            // 
            lblCalculatedStatus.AutoSize = true;
            lblCalculatedStatus.Font = new Font("Segoe UI", 11.25F);
            lblCalculatedStatus.Location = new Point(156, 187);
            lblCalculatedStatus.Name = "lblCalculatedStatus";
            lblCalculatedStatus.Size = new Size(37, 20);
            lblCalculatedStatus.TabIndex = 5;
            lblCalculatedStatus.Text = "[---]";
            // 
            // lblCalculatedHousing
            // 
            lblCalculatedHousing.AutoSize = true;
            lblCalculatedHousing.Font = new Font("Bookman Old Style", 11.25F);
            lblCalculatedHousing.Location = new Point(156, 238);
            lblCalculatedHousing.Name = "lblCalculatedHousing";
            lblCalculatedHousing.Size = new Size(37, 19);
            lblCalculatedHousing.TabIndex = 6;
            lblCalculatedHousing.Text = "[---]";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.25F);
            btnAdd.Location = new Point(20, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 33);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(41, 128, 185);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 11.25F);
            btnSave.Location = new Point(216, 303);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 33);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11.25F);
            btnClear.Location = new Point(388, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 33);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Font = new Font("Segoe UI", 11.25F);
            txtSearchID.Location = new Point(15, 22);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(351, 27);
            txtSearchID.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 11.25F);
            btnSearch.Location = new Point(519, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(184, 32);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search ID";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.25F);
            btnDelete.Location = new Point(519, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete Selected Animal";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(15, 119);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(707, 263);
            dgvAnimals.TabIndex = 13;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Font = new Font("Segoe UI", 11.25F);
            btnGenerateSummary.Location = new Point(42, 35);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(847, 47);
            btnGenerateSummary.TabIndex = 14;
            btnGenerateSummary.Text = "Generate Summary\r\n";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // lblSummaryTotal
            // 
            lblSummaryTotal.AutoSize = true;
            lblSummaryTotal.Font = new Font("Segoe UI", 11.25F);
            lblSummaryTotal.Location = new Point(266, 116);
            lblSummaryTotal.Name = "lblSummaryTotal";
            lblSummaryTotal.Size = new Size(37, 20);
            lblSummaryTotal.TabIndex = 15;
            lblSummaryTotal.Text = "[---]";
            // 
            // lblSummaryAvgAge
            // 
            lblSummaryAvgAge.AutoSize = true;
            lblSummaryAvgAge.Font = new Font("Segoe UI", 11.25F);
            lblSummaryAvgAge.Location = new Point(266, 158);
            lblSummaryAvgAge.Name = "lblSummaryAvgAge";
            lblSummaryAvgAge.Size = new Size(37, 20);
            lblSummaryAvgAge.TabIndex = 16;
            lblSummaryAvgAge.Text = "[---]";
            // 
            // lblSummaryAvgScore
            // 
            lblSummaryAvgScore.AutoSize = true;
            lblSummaryAvgScore.Font = new Font("Segoe UI", 11.25F);
            lblSummaryAvgScore.Location = new Point(266, 197);
            lblSummaryAvgScore.Name = "lblSummaryAvgScore";
            lblSummaryAvgScore.Size = new Size(37, 20);
            lblSummaryAvgScore.TabIndex = 17;
            lblSummaryAvgScore.Text = "[---]";
            // 
            // lblCountCritical
            // 
            lblCountCritical.AutoSize = true;
            lblCountCritical.Font = new Font("Segoe UI", 11.25F);
            lblCountCritical.Location = new Point(558, 116);
            lblCountCritical.Name = "lblCountCritical";
            lblCountCritical.Size = new Size(37, 20);
            lblCountCritical.TabIndex = 18;
            lblCountCritical.Text = "[---]";
            // 
            // lblCountSerious
            // 
            lblCountSerious.AutoSize = true;
            lblCountSerious.Font = new Font("Segoe UI", 11.25F);
            lblCountSerious.Location = new Point(558, 197);
            lblCountSerious.Name = "lblCountSerious";
            lblCountSerious.Size = new Size(37, 20);
            lblCountSerious.TabIndex = 19;
            lblCountSerious.Text = "[---]";
            // 
            // lblCountStable
            // 
            lblCountStable.AutoSize = true;
            lblCountStable.Font = new Font("Segoe UI", 11.25F);
            lblCountStable.Location = new Point(558, 158);
            lblCountStable.Name = "lblCountStable";
            lblCountStable.Size = new Size(37, 20);
            lblCountStable.TabIndex = 20;
            lblCountStable.Text = "[---]";
            // 
            // lblCountRecovering
            // 
            lblCountRecovering.AutoSize = true;
            lblCountRecovering.Font = new Font("Segoe UI", 11.25F);
            lblCountRecovering.Location = new Point(852, 119);
            lblCountRecovering.Name = "lblCountRecovering";
            lblCountRecovering.Size = new Size(37, 20);
            lblCountRecovering.TabIndex = 21;
            lblCountRecovering.Text = "[---]";
            // 
            // lblCountReleaseReady
            // 
            lblCountReleaseReady.AutoSize = true;
            lblCountReleaseReady.Font = new Font("Segoe UI", 11.25F);
            lblCountReleaseReady.Location = new Point(852, 158);
            lblCountReleaseReady.Name = "lblCountReleaseReady";
            lblCountReleaseReady.Size = new Size(37, 20);
            lblCountReleaseReady.TabIndex = 22;
            lblCountReleaseReady.Text = "[---]";
            // 
            // grpAnimalDetails
            // 
            grpAnimalDetails.Controls.Add(pictureBox1);
            grpAnimalDetails.Controls.Add(lblHousingStatic);
            grpAnimalDetails.Controls.Add(lblStatusStatic);
            grpAnimalDetails.Controls.Add(lblRecoveryScoreStatic);
            grpAnimalDetails.Controls.Add(lblAgeStatic);
            grpAnimalDetails.Controls.Add(lblSpeciesStatic);
            grpAnimalDetails.Controls.Add(lblNameStatic);
            grpAnimalDetails.Controls.Add(lblAnimalIDStatic);
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
            grpAnimalDetails.Location = new Point(33, 24);
            grpAnimalDetails.Margin = new Padding(3, 5, 3, 5);
            grpAnimalDetails.Name = "grpAnimalDetails";
            grpAnimalDetails.Padding = new Padding(3, 5, 3, 5);
            grpAnimalDetails.Size = new Size(595, 518);
            grpAnimalDetails.TabIndex = 23;
            grpAnimalDetails.TabStop = false;
            grpAnimalDetails.Text = "Animal Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(275, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblHousingStatic
            // 
            lblHousingStatic.AutoSize = true;
            lblHousingStatic.Font = new Font("Segoe UI", 11.25F);
            lblHousingStatic.Location = new Point(20, 238);
            lblHousingStatic.Name = "lblHousingStatic";
            lblHousingStatic.Size = new Size(64, 20);
            lblHousingStatic.TabIndex = 16;
            lblHousingStatic.Text = "Housing";
            // 
            // lblStatusStatic
            // 
            lblStatusStatic.AutoSize = true;
            lblStatusStatic.Font = new Font("Segoe UI", 11.25F);
            lblStatusStatic.Location = new Point(20, 187);
            lblStatusStatic.Name = "lblStatusStatic";
            lblStatusStatic.Size = new Size(49, 20);
            lblStatusStatic.TabIndex = 15;
            lblStatusStatic.Text = "Status";
            // 
            // lblRecoveryScoreStatic
            // 
            lblRecoveryScoreStatic.AutoSize = true;
            lblRecoveryScoreStatic.Font = new Font("Segoe UI", 11.25F);
            lblRecoveryScoreStatic.Location = new Point(20, 148);
            lblRecoveryScoreStatic.Name = "lblRecoveryScoreStatic";
            lblRecoveryScoreStatic.Size = new Size(110, 20);
            lblRecoveryScoreStatic.TabIndex = 14;
            lblRecoveryScoreStatic.Text = "Recovery Score";
            // 
            // lblAgeStatic
            // 
            lblAgeStatic.AutoSize = true;
            lblAgeStatic.Font = new Font("Segoe UI", 11.25F);
            lblAgeStatic.Location = new Point(20, 119);
            lblAgeStatic.Name = "lblAgeStatic";
            lblAgeStatic.Size = new Size(36, 20);
            lblAgeStatic.TabIndex = 13;
            lblAgeStatic.Text = "Age";
            // 
            // lblSpeciesStatic
            // 
            lblSpeciesStatic.AutoSize = true;
            lblSpeciesStatic.Font = new Font("Segoe UI", 11.25F);
            lblSpeciesStatic.Location = new Point(20, 89);
            lblSpeciesStatic.Name = "lblSpeciesStatic";
            lblSpeciesStatic.Size = new Size(59, 20);
            lblSpeciesStatic.TabIndex = 12;
            lblSpeciesStatic.Text = "Species";
            // 
            // lblNameStatic
            // 
            lblNameStatic.AutoSize = true;
            lblNameStatic.Font = new Font("Segoe UI", 11.25F);
            lblNameStatic.Location = new Point(20, 62);
            lblNameStatic.Name = "lblNameStatic";
            lblNameStatic.Size = new Size(100, 20);
            lblNameStatic.TabIndex = 11;
            lblNameStatic.Text = "Animal Name";
            // 
            // lblAnimalIDStatic
            // 
            lblAnimalIDStatic.AutoSize = true;
            lblAnimalIDStatic.Font = new Font("Segoe UI", 11.25F);
            lblAnimalIDStatic.Location = new Point(20, 31);
            lblAnimalIDStatic.Name = "lblAnimalIDStatic";
            lblAnimalIDStatic.Size = new Size(75, 20);
            lblAnimalIDStatic.TabIndex = 10;
            lblAnimalIDStatic.Text = "Animal ID";
            // 
            // grpSearchActions
            // 
            grpSearchActions.Controls.Add(dgvAnimals);
            grpSearchActions.Controls.Add(txtSearchID);
            grpSearchActions.Controls.Add(btnSearch);
            grpSearchActions.Controls.Add(btnDelete);
            grpSearchActions.Location = new Point(634, 24);
            grpSearchActions.Name = "grpSearchActions";
            grpSearchActions.Size = new Size(734, 518);
            grpSearchActions.TabIndex = 10;
            grpSearchActions.TabStop = false;
            grpSearchActions.Text = "Search";
            // 
            // grpSummaryReport
            // 
            grpSummaryReport.Controls.Add(lblReadyReleaseCount);
            grpSummaryReport.Controls.Add(lblRecoveringCountStatic);
            grpSummaryReport.Controls.Add(lblSeriousCountStatic);
            grpSummaryReport.Controls.Add(lblStableCountStatic);
            grpSummaryReport.Controls.Add(lblCriticalCountStatic);
            grpSummaryReport.Controls.Add(lblSummaryAverageScoreStatic);
            grpSummaryReport.Controls.Add(lblSummaryAvgAgeStatic);
            grpSummaryReport.Controls.Add(lblSummaryTotalStatic);
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
            // lblReadyReleaseCount
            // 
            lblReadyReleaseCount.AutoSize = true;
            lblReadyReleaseCount.Font = new Font("Segoe UI", 11.25F);
            lblReadyReleaseCount.Location = new Point(654, 157);
            lblReadyReleaseCount.Name = "lblReadyReleaseCount";
            lblReadyReleaseCount.Size = new Size(153, 20);
            lblReadyReleaseCount.TabIndex = 30;
            lblReadyReleaseCount.Text = "Release-Ready Count:";
            // 
            // lblRecoveringCountStatic
            // 
            lblRecoveringCountStatic.AutoSize = true;
            lblRecoveringCountStatic.Font = new Font("Segoe UI", 11.25F);
            lblRecoveringCountStatic.Location = new Point(654, 116);
            lblRecoveringCountStatic.Name = "lblRecoveringCountStatic";
            lblRecoveringCountStatic.Size = new Size(129, 20);
            lblRecoveringCountStatic.TabIndex = 29;
            lblRecoveringCountStatic.Text = "Recovering Count:";
            // 
            // lblSeriousCountStatic
            // 
            lblSeriousCountStatic.AutoSize = true;
            lblSeriousCountStatic.Font = new Font("Segoe UI", 11.25F);
            lblSeriousCountStatic.Location = new Point(388, 197);
            lblSeriousCountStatic.Name = "lblSeriousCountStatic";
            lblSeriousCountStatic.Size = new Size(103, 20);
            lblSeriousCountStatic.TabIndex = 28;
            lblSeriousCountStatic.Text = "Serious Count:";
            // 
            // lblStableCountStatic
            // 
            lblStableCountStatic.AutoSize = true;
            lblStableCountStatic.Font = new Font("Segoe UI", 11.25F);
            lblStableCountStatic.Location = new Point(388, 157);
            lblStableCountStatic.Name = "lblStableCountStatic";
            lblStableCountStatic.Size = new Size(97, 20);
            lblStableCountStatic.TabIndex = 27;
            lblStableCountStatic.Text = "Stable Count:";
            // 
            // lblCriticalCountStatic
            // 
            lblCriticalCountStatic.AutoSize = true;
            lblCriticalCountStatic.Font = new Font("Segoe UI", 11.25F);
            lblCriticalCountStatic.Location = new Point(388, 119);
            lblCriticalCountStatic.Name = "lblCriticalCountStatic";
            lblCriticalCountStatic.Size = new Size(101, 20);
            lblCriticalCountStatic.TabIndex = 26;
            lblCriticalCountStatic.Text = "Critical Count:";
            // 
            // lblSummaryAverageScoreStatic
            // 
            lblSummaryAverageScoreStatic.AutoSize = true;
            lblSummaryAverageScoreStatic.Font = new Font("Segoe UI", 11.25F);
            lblSummaryAverageScoreStatic.Location = new Point(42, 197);
            lblSummaryAverageScoreStatic.Name = "lblSummaryAverageScoreStatic";
            lblSummaryAverageScoreStatic.Size = new Size(174, 20);
            lblSummaryAverageScoreStatic.TabIndex = 25;
            lblSummaryAverageScoreStatic.Text = "Summary Average Score:";
            // 
            // lblSummaryAvgAgeStatic
            // 
            lblSummaryAvgAgeStatic.AutoSize = true;
            lblSummaryAvgAgeStatic.Font = new Font("Segoe UI", 11.25F);
            lblSummaryAvgAgeStatic.Location = new Point(42, 157);
            lblSummaryAvgAgeStatic.Name = "lblSummaryAvgAgeStatic";
            lblSummaryAvgAgeStatic.Size = new Size(164, 20);
            lblSummaryAvgAgeStatic.TabIndex = 24;
            lblSummaryAvgAgeStatic.Text = "Summary Average Age:";
            // 
            // lblSummaryTotalStatic
            // 
            lblSummaryTotalStatic.AutoSize = true;
            lblSummaryTotalStatic.Font = new Font("Segoe UI", 11.25F);
            lblSummaryTotalStatic.Location = new Point(42, 116);
            lblSummaryTotalStatic.Name = "lblSummaryTotalStatic";
            lblSummaryTotalStatic.Size = new Size(111, 20);
            lblSummaryTotalStatic.TabIndex = 23;
            lblSummaryTotalStatic.Text = "Summary Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1385, 812);
            Controls.Add(grpSummaryReport);
            Controls.Add(grpSearchActions);
            Controls.Add(grpAnimalDetails);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife Records";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            grpAnimalDetails.ResumeLayout(false);
            grpAnimalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblAgeStatic;
        private Label lblSpeciesStatic;
        private Label lblNameStatic;
        private Label lblAnimalIDStatic;
        private Label lblRecoveryScoreStatic;
        private Label lblSummaryAvgAgeStatic;
        private Label lblSummaryTotalStatic;
        private Label lblSummaryAverageScoreStatic;
        private Label lblReadyReleaseCount;
        private Label lblRecoveringCountStatic;
        private Label lblSeriousCountStatic;
        private Label lblStableCountStatic;
        private Label lblCriticalCountStatic;
        private Label lblHousingStatic;
        private Label lblStatusStatic;
        private PictureBox pictureBox1;
    }
}
