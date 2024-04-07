using System;
using CypherWithGuna;
using System.Windows.Forms;
namespace CypherWithGuna
{
    internal static class Program
    {
    [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPageWithGuna());
        }
    }
}

