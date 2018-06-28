using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for drawFromFile.xaml
    /// </summary>
    public partial class drawFromFile : UserControl
    {
        //array to store points
        List<double> coOffset = new List<double>();

        public drawFromFile()
        {
            InitializeComponent();
        }


        //set points
        public void SetData()
        {
            //###set points


            //redraw
            InitializeComponent();
        }

        //onRender
        protected override void OnRender(DrawingContext context)
        {
            base.OnRender(context);

            //you need a pen to draw


            //get middle white Point
            Point middleStart = new Point(ActualWidth / 2 - ActualWidth * .01, ActualHeight * .1);
            Point middleEnd = new Point(ActualWidth / 2, ActualHeight * .15);

            //get black rec Point
            Point recStart = new Point(middleStart.X - ActualWidth * .015, middleStart.Y);
            Point recEnd = new Point(middleEnd.X + ActualWidth * .015, middleEnd.Y);
            context.DrawRectangle(Brushes.Black, null, new Rect(recStart, recEnd));
            context.DrawRectangle(Brushes.White, null, new Rect(middleStart, middleEnd));
            double middley_interval = ActualHeight * .1;
            for (int i = 1; i < 7; i++)
            {
                middleStart.Y += middley_interval;
                middleEnd.Y += middley_interval;
                recStart.X -= middley_interval * .1;
                recStart.Y = middleStart.Y;
                recEnd.X += middley_interval * .1;
                recEnd.Y = middleEnd.Y;
                context.DrawRectangle(Brushes.Black, null, new Rect(recStart, recEnd));

                //draw a filled retangle
                context.DrawRectangle(Brushes.White, null, new Rect(middleStart, middleEnd));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                TextReader reader = new StreamReader(openFileDialog.FileName);
                List<double> values = new List<double>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //assuming that a single value per line
                    values.Add(Convert.ToDouble(line));
                    //if there are multiple value per line
                    //use the Split() to chunk into parts
                }
                //user control is plotter and it uses a single double for a point
                //###
                //this.SetData(values.ToArray<double>());
            }

        }
    }
}
