using Monopoly.BLL;
using System;
using System.Configuration;
using System.Windows.Forms;
using Monopoly.BLL;

namespace Monopoly
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AuthService authService = new AuthService();
            ApplicationConfiguration.Initialize();
            Application.Run(new SignIn(authService));
        }
    }
}