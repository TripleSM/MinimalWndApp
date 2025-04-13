/*
csc Program.cs /target:winexe /R:"WPF\PresentationCore.dll","WPF\PresentationFramework.dll","WPF\WindowsBase.dll"
*/

using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimpleCalc
{

    internal class MainWindow : Window
    {
        string strMessage = "Hello World!";

        Grid calcGrid = new Grid();

        TextBox tbxFirstNo;
        TextBox tbxSecondNo;
        TextBox tbxResult;

        Button btnAdd;
        Button btnSubtract;
        Button btnMultiply;
        Button btnDevide;
        Button btnClear;

        public void CreateWindowLayout()
        {
            //calcGrid.HorizontalAlignment = HorizontalAlignment.Center;
            //calcGrid.VerticalAlignment = VerticalAlignment.Center;
            //calcGrid.Width = 320;
            //calcGrid.Height = 200;
            calcGrid.ShowGridLines = true;

            // Define the Rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            calcGrid.RowDefinitions.Add(rowDef1);
            calcGrid.RowDefinitions.Add(rowDef2);
            calcGrid.RowDefinitions.Add(rowDef3);
            calcGrid.RowDefinitions.Add(rowDef4);

            // Define the Columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            calcGrid.ColumnDefinitions.Add(colDef1);
            calcGrid.ColumnDefinitions.Add(colDef2);
            calcGrid.ColumnDefinitions.Add(colDef3);

            this.Content = calcGrid;
        }

        private void CreateFirstLineElements()
        {
            TextBlock tblFirstNo = new TextBlock();
            tblFirstNo.Text = "Firat No";
            tblFirstNo.FontSize = 12;
            tblFirstNo.FontWeight = FontWeights.Bold;
            Grid.SetRow(tblFirstNo, 0);
            Grid.SetColumn(tblFirstNo, 0);
            calcGrid.Children.Add(tblFirstNo);

            tbxFirstNo = new TextBox();
            Grid.SetRow(tbxFirstNo, 0);
            Grid.SetColumn(tbxFirstNo, 1);
            calcGrid.Children.Add(tbxFirstNo);

            btnAdd = new Button();
            btnAdd.Content = "+";
            btnAdd.FontSize = 18;
            btnAdd.FontWeight = FontWeights.Bold;
            Grid.SetRow(btnAdd, 0);
            Grid.SetColumn(btnAdd, 2);
            calcGrid.Children.Add(btnAdd);
        }

        private void CreateSecondLineElements()
        {
            TextBlock tblSecondNo = new TextBlock();
            tblSecondNo.Text = "Second No";
            tblSecondNo.FontSize = 12;
            tblSecondNo.FontWeight = FontWeights.Bold;
            Grid.SetRow(tblSecondNo, 1);
            Grid.SetColumn(tblSecondNo, 0);
            calcGrid.Children.Add(tblSecondNo);

            tbxSecondNo = new TextBox();
            Grid.SetRow(tbxSecondNo, 1);
            Grid.SetColumn(tbxSecondNo, 1);
            calcGrid.Children.Add(tbxSecondNo);

            btnSubtract = new Button();
            btnSubtract.Content = "-";
            btnSubtract.FontSize = 18;
            btnSubtract.FontWeight = FontWeights.Bold;
            Grid.SetRow(btnSubtract, 1);
            Grid.SetColumn(btnSubtract, 2);
            calcGrid.Children.Add(btnSubtract);
        }

        private void CreateThirdLineElements()
        {
            TextBlock tblResult = new TextBlock();
            tblResult.Text = "Result";
            tblResult.FontSize = 12;
            tblResult.FontWeight = FontWeights.Bold;
            Grid.SetRow(tblResult, 2);
            Grid.SetColumn(tblResult, 0);
            calcGrid.Children.Add(tblResult);

            tbxResult = new TextBox();
            Grid.SetRow(tbxResult, 2);
            Grid.SetColumn(tbxResult, 1);
            calcGrid.Children.Add(tbxResult);

            btnMultiply = new Button();
            btnMultiply.Content = "*";
            btnMultiply.FontSize = 18;
            btnMultiply.FontWeight = FontWeights.Bold;
            Grid.SetRow(btnMultiply, 2);
            Grid.SetColumn(btnMultiply, 2);
            calcGrid.Children.Add(btnMultiply);
        }

        private void CreateFourthLineElements()
        {
            btnClear = new Button();
            btnClear.Content = "Clear";
            btnClear.FontSize = 12;
            btnClear.FontWeight = FontWeights.Bold;
            Grid.SetRow(btnClear, 3);
            Grid.SetColumn(btnClear, 1);
            calcGrid.Children.Add(btnClear);

            btnDevide = new Button();
            btnDevide.Content = "/";
            btnDevide.FontSize = 18;
            btnDevide.FontWeight = FontWeights.Bold;
            Grid.SetRow(btnDevide, 3);
            Grid.SetColumn(btnDevide, 2);
            calcGrid.Children.Add(btnDevide);
        }

        public MainWindow()
        {
            this.Title = "Window Minimal App";
            this.Width = 640;
            this.Height = 400;

            //this.Content = strMessage;

            CreateWindowLayout();
            CreateFirstLineElements();
            CreateSecondLineElements();
            CreateThirdLineElements();
            CreateFourthLineElements();

            btnAdd.Click += BtnAdd_Click;
            btnSubtract.Click += BtnSubtract_Click;
            btnMultiply.Click += BtnMultiply_Click;
            btnDevide.Click += BtnDevide_Click;
            btnClear.Click += BtnClear_Click;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            int firstNo = 0, secondNo = 0;
            if (Int32.TryParse(tbxFirstNo.Text, out firstNo) && Int32.TryParse(tbxSecondNo.Text, out secondNo))
            {
                int result = firstNo + secondNo;
                tbxResult.Text = result.ToString();
            }
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            int firstNo = 0, secondNo = 0;
            if (Int32.TryParse(tbxFirstNo.Text, out firstNo) && Int32.TryParse(tbxSecondNo.Text, out secondNo))
            {
                int result = firstNo - secondNo;
                tbxResult.Text = result.ToString();
            }
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            int firstNo = 0, secondNo = 0;
            if (Int32.TryParse(tbxFirstNo.Text, out firstNo) && Int32.TryParse(tbxSecondNo.Text, out secondNo))
            {
                int result = firstNo * secondNo;
                tbxResult.Text = result.ToString();
            }
        }

        private void BtnDevide_Click(object sender, RoutedEventArgs e)
        {
            int firstNo = 0, secondNo = 0;
            if (Int32.TryParse(tbxFirstNo.Text, out firstNo) && Int32.TryParse(tbxSecondNo.Text, out secondNo))
            {
                if(secondNo != 0)
                {
                    int result = firstNo / secondNo;
                    tbxResult.Text = result.ToString();
                }
                else
                {
                    tbxResult.Text = "Devide by 0 error.";
                }
            }     
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxFirstNo.Text = "";
            tbxSecondNo.Text = "";
            tbxResult.Text = "";
        }
    }  
    
    internal class Program
    {          
        [STAThread]
        static void Main(string[] args)
        {
            Window theWindow = new MainWindow();

            Application app = new Application();
            app.Run(theWindow);
        }
    }
}
