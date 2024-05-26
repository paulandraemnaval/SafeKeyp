using Google.Cloud.Firestore.V1;
using Cypher.Classes;
using Cypher.Forms;
namespace Cypher.Classes
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
            FirebaseHelper.SetEnvironmentVariable();

            ApplicationConfiguration.Initialize();
            Application.Run(new AppStartPage());
        }
    }
}