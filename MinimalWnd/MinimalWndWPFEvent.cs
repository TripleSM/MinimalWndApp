/*
csc.exe MinimalWndWPF.cs /out:WPFApplication.exe /target:winexe /reference:"WPF\presentationframework.dll","WPF\windowsbase.dll","WPF\presentationcore.dll"
*/

using System;
using System.Windows;
using System.Windows.Controls;

namespace MinimalWndWPF
{

    class MainWindow : Window // Declare a class that derives from the Window class
    {
        string strMessage = "Hello World!";

        public MainWindow()   // Constructor
        {
            //Set Window basic properties.
            Width = 640;
            Height = 400;
            Title = "Test Window"; // Set the title.
            Content = strMessage; // Set the window content.

            this.Activated += AppActivated;
            this.Deactivated += AppDeactivated;
        }

        static void AppActivated(object sender, EventArgs e)
        {
            Console.WriteLine("Window has Activated");
        }

        static void AppDeactivated(object sender, EventArgs e)
        {
            Console.WriteLine("Window has Deactivated");
        }
    }

    class TestApplication : Application
    {
       
        public TestApplication() 
        {
            this.Startup += AppStartUp;  
            this.Exit += AppExit;
        }

        static void AppStartUp(object sender, StartupEventArgs e)
        {
            Console.WriteLine("App has Started");
            Window mainWindow = new MainWindow(); // Create the Window object.
            mainWindow.Show();
        }

        static void AppExit(object sender, ExitEventArgs e)
        {
            Console.WriteLine("App has exited");
        }

        [STAThread]
        static void Main(string[] args)
        {            
            TestApplication theApp = new TestApplication(); // Create an Application object.
            //theApp.MainWindow = mainWindow;
            theApp.Run(); // Start application running.
        }
    }

}
