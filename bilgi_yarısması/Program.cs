namespace bilgi_yarısması
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (splash splashform = new splash())
            {
                splashform.ShowDialog();
            }
                Application.Run(new Form1());
        }
    }
}