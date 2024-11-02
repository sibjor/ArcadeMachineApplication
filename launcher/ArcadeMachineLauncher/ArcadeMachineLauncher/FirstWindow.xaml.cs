using System.DirectoryServices.Protocols;
using System.IO;
using System.Windows;
using Microsoft.Win32;


namespace ArcadeMachineLauncher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DirectoryManeuver dirManeuver = new DirectoryManeuver();
            dirManeuver.DirectoryMethod();
        }

        
        
    }
}