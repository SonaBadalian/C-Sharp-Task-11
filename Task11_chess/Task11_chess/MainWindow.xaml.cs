//To be continued

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

namespace Task11_chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool BnFigureClicked, BrFigureClicked, BbFigureClicked, BkFigureClicked,
             WkFigureClicked, WpFigureClicked;
        double DeltaX, DeltaY;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (BnFigureClicked)
                MyBnFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);

            if (BrFigureClicked)
                MyBrFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);

            if (BbFigureClicked)
                MyBbFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);

            if (BkFigureClicked)
                MyBkFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);

            if (WkFigureClicked)
                MyWkFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);

            if (WpFigureClicked)
                MyWpFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                e.GetPosition(this).Y - DeltaY, 0, 0);


        }

        private void MyBnFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BnFigureClicked = true;

            DeltaX = e.GetPosition(this).X - MyBnFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyBnFigure.Margin.Top;

        }
        private void MyBnFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BnFigureClicked = false;
            MyBnFigure.Margin = new Thickness((int)(MyBnFigure.Margin.Left + 25) / 50 *
            50, (int)(MyBnFigure.Margin.Top + 25) / 50 * 50, 0, 0);

        }


        private void MyBrFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BrFigureClicked = true;
            DeltaX = e.GetPosition(this).X - MyBrFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyBrFigure.Margin.Top;

        }
        private void MyBrFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BrFigureClicked = false;
            MyBrFigure.Margin = new Thickness((int)(MyBrFigure.Margin.Left + 25) / 50 * 50,
            (int)(MyBrFigure.Margin.Top + 25) / 50 * 50, 0, 0);
           
        }

        private void MyBbFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BbFigureClicked = true;

            DeltaX = e.GetPosition(this).X - MyBbFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyBbFigure.Margin.Top;

        }
        private void MyBbFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BbFigureClicked = false;
            MyBbFigure.Margin = new Thickness((int)(MyBbFigure.Margin.Left + 25) / 50 *
            50, (int)(MyBbFigure.Margin.Top + 25) / 50 * 50, 0, 0);

        }


        private void MyBkFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            BkFigureClicked = true;

            DeltaX = e.GetPosition(this).X - MyBkFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyBkFigure.Margin.Top;

        }
        private void MyBkFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BkFigureClicked = false;
            MyBkFigure.Margin = new Thickness((int)(MyBkFigure.Margin.Left + 25) / 50 *
            50, (int)(MyBkFigure.Margin.Top + 25) / 50 * 50, 0, 0);

        }


        private void MyWkFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WkFigureClicked = true;

            DeltaX = e.GetPosition(this).X - MyWkFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyWkFigure.Margin.Top;

        }
        private void MyWkFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WkFigureClicked = false;
            MyWkFigure.Margin = new Thickness((int)(MyWkFigure.Margin.Left + 25) / 50 *
            50, (int)(MyWkFigure.Margin.Top + 25) / 50 * 50, 0, 0);

        }

        private void MyWpFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpFigureClicked = true;

            DeltaX = e.GetPosition(this).X - MyWpFigure.Margin.Left;
            DeltaY = e.GetPosition(this).Y - MyWpFigure.Margin.Top;

        }
        private void MyWpFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WpFigureClicked = false;
            MyWpFigure.Margin = new Thickness((int)(MyWpFigure.Margin.Left + 25) / 50 *
            50, (int)(MyWpFigure.Margin.Top + 25) / 50 * 50, 0, 0);

        }
    }
    }
