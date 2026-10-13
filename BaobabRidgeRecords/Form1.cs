namespace BaobabRidgeRecords
{
    public partial class Form1 : Form
    {
        private List<Animal> animalList = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void grpAnimalDetails_Enter(object sender, EventArgs e)
        {

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
    }
}
