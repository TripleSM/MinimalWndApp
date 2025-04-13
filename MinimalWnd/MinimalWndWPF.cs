/*
csc.exe MinimalWndWPF.cs /out:WPFApplication.exe /target:winexe /reference:"WPF\presentationframework.dll","WPF\windowsbase.dll","WPF\presentationcore.dll"
*/

using System;
using System.Windows;
using System.Windows.Controls;

namespace MinimalWndWPF
{
    internal class TestApplication
    {
        [STAThread]
        static void Main(string[] args)
        {
            string strMessage = "Hello World!";
            
            Window theWindow = new Window(); // Create the Window object.
            theWindow.Title = "Test Window App"; // Set the title.
            
            theWindow.Content = strMessage; // Set the window content.

            /*TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = strMessage;
            textBlock1.VerticalAlignment = VerticalAlignment.Center;
            textBlock1.HorizontalAlignment = HorizontalAlignment.Center;
            theWindow.Content = textBlock1;*/

            Application theApp = new Application(); // Create an Application object.
            theApp.Run(theWindow); // Start application running.
        }
    }
}
