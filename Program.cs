namespace _05_12_2022_Win_form_microsoft
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
            DialogResult result = MessageBox.Show("Вы готовы учиться?",
                "Окно1", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Хорошо");
            }
           

        }
    }
}