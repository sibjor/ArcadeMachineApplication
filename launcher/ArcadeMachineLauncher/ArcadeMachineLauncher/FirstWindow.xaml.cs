using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ArcadeMachineLauncher
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> gameDirectories = new();

        public MainWindow()
        {
            InitializeComponent();
            LoadDirectories();
        }

        private void LoadDirectories()
        {
            DirectoryManeuver dirManeuver = new DirectoryManeuver();
            string[] directories = dirManeuver.DirectoryMethod();

            foreach (var fullPath in directories)
            {
                string dirName = Path.GetFileName(fullPath); // Get only the directory name
                gameDirectories[dirName] = fullPath; // Store the name and full path

                // Add directory name to the ListBox
                GamesListBox.Items.Add(dirName);
            }

            if (gameDirectories.Count == 0)
            {
                MessageBox.Show("No game directories found.");
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (GamesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a game to start.");
                return;
            }

            string selectedGame = GamesListBox.SelectedItem.ToString();
            if (gameDirectories.TryGetValue(selectedGame, out string selectedDirectory))
            {
                // Look for the .exe file in the selected directory
                string exePath = Directory.GetFiles(selectedDirectory, "*.exe").FirstOrDefault();

                if (exePath != null && File.Exists(exePath))
                {
                    try
                    {
                        Process.Start(exePath);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show($"Failed to start the game. Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No executable file found in the selected directory.");
                }
            }
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Arcade Machine Launcher\nVersion 1.0\nDeveloped by [Your Name]");
        }
    }
}
