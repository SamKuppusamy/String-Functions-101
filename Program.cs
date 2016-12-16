using System;
using System.Windows.Forms;

/// <summary>
/// ParsingApp
/// </summary>
namespace ParsingApp
{
    /// <summary>
    /// Program
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmParserMain());
        }
    }
}