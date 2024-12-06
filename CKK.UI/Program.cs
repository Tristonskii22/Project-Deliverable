using CKK.Logic.Models;
namespace CKK.UI
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
            Form1 form1 = new Form1();
            Application.Run(form1);
            Store store = new Store();
            if(form1.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form2(store));
            }

        }
    }
}