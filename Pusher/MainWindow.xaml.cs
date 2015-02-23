using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pusher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush header, closeHover, closeClick;

        public MainWindow()
        {
            InitializeComponent();
            //DwmDropShadow.DropShadowToWindow(this);
            header = new SolidColorBrush(Color.FromArgb(255, 74, 179, 103));
            closeHover = new SolidColorBrush(Color.FromArgb(255, 68, 164, 95));
            closeClick = new SolidColorBrush(Color.FromArgb(255, 149, 165, 166));

            Header.Fill = header;
            CloseBackground.Fill = header;
        }

        // ALLWAYS call this to exit the application. Ensures proper shutdown or restart
        public void Exit(bool restart = false)
        {
            if (restart)
            {
                Console.WriteLine("Restarting application");
            }
            else
            {
                Console.WriteLine("Exiting application");
            }

            //Do shutdown activities here
            this.Close();
            
            if (restart)
            {
                Console.WriteLine("Application restarting...");
            }
            else
            {
                Console.WriteLine("Application exited safely");
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseBackground_MouseEnter(object sender, MouseEventArgs e)
        {
            this.CloseBackground.Fill = closeHover;
        }

        private void CloseBackground_MouseLeave(object sender, MouseEventArgs e)
        {
            this.CloseBackground.Fill = header;
        }

        private void CloseBackground_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Closing the application!");
            this.CloseBackground.Fill = header;
            Exit();
        }

        private void CloseBackground_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.CloseBackground.Fill = closeClick;
            e.Handled = true;
        }
    }
}
