namespace SIS
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
            LoginPicker loginPicker = new LoginPicker();
            //if (loginPicker.ShowDialog() != DialogResult.OK) { Application.Exit(); }
            //else { Application.Run(new MainForm()); }
            Application.Run(new MainForm());//remove after dev or comment
        }
    }
}