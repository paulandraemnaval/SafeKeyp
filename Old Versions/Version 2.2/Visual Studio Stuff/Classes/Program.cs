using System;
using CypherWithGuna;
using System.Windows.Forms;
using CypherWithGuna.Classes;
namespace CypherWithGuna
{
    internal static class Program
    {
    [STAThread]
        private static void Main()
        {
            FireBaseHelper.SetEnvironmentVariable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SafeKeypMainpage());
        }
    }
}

