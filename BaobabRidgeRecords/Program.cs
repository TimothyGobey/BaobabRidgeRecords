namespace BaobabRidgeRecords
{
    internal static class Program
    {
        // The main entry point that launches the application and opens the main form.
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}