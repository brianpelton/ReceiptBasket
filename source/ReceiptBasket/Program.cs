using System;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator]

namespace ReceiptBasket
{
    internal static class Program
    {
        #region [ Methods ]

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppShell());
        }

        #endregion
    }
}