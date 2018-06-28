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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for drawPractice.xaml
    /// </summary>
    public partial class drawPractice : UserControl
    {
        public drawPractice()
        {
            InitializeComponent();
        }

        protected override void OnRender(DrawingContext context)
        {
            base.OnRender(context);

            double width = ActualWidth * 0.9;
            double height = ActualHeight * 0.9;

            Point start = new Point(width * .1, height * .1);
            Point end = new Point(width, height);


            //you need a pen to draw
            Pen pen = new Pen(Brushes.Brown, 3.5);

            //draw a filled retangle
            context.DrawRectangle(Brushes.LightCyan, pen, new Rect(start, end));

            start = new Point(width * .3, height * .4);
            end = new Point(width * .95, height * .95);
            pen = new Pen(Brushes.DarkGreen, 5);

            //draw a rectanglular outline
            context.DrawRectangle(null, pen, new Rect(start, end));

            Point center = new Point(width / 2, height / 2);
            pen = new Pen(Brushes.Yellow, 5);

            //draw a circle
            context.DrawEllipse(null, pen, center, 200, 200);



            //create a radial brush
            Brush _brush = new RadialGradientBrush(Color.FromRgb(255, 0, 0), Color.FromRgb(0, 0, 255));

            start = new Point(width * .1, height * .2);
            end = new Point(width * .95, height * .2);

            //draw a line
            pen = new Pen(_brush, 10);
            context.DrawLine(pen, start, end);

        }
    }
}