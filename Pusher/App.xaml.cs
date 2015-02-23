using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Pusher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("App Start!");
            try
            {
                App application = new App();
                application.ShutdownMode = ShutdownMode.OnMainWindowClose;
                application.InitializeComponent();
                application.Run();
                Console.WriteLine("App exiting cleanly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("App main() failed. Exception: {0}", ex.ToString());
            }
        }
    }
}
