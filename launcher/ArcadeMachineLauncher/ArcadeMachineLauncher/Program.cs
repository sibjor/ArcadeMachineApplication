﻿using System;
using System.Windows;

namespace ArcadeMachineLauncher
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new Application();
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}