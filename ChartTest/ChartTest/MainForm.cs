using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            LineSeries series = new LineSeries
            {
                Title = "Продажи",
                Values = new ChartValues<int> { 10, 15, 12, 18, 25, 22 },

                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 4,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                    System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                    90),
            };
                

            cartesian.Series = new SeriesCollection { series, /*series_2, series_3*/ };

            /// Ось Y
            cartesian.AxisY.Add(new Axis
            { 
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 5
                },

                MaxValue = 30,
                MinValue = 1
            }              
            );


            /// Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                Labels = new[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" },

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }

        void FillAngular()
        {
            angular.Value = 110;
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Gray;
            angular.NeedleFill = Brushes.DarkBlue;
            angular.TickStep = 5;
            angular.LabelsStep = 10;
        }

        void FillSolid()
        {
            solid.Value = 70;
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
            solid.Base.LabelsVisibility = System.Windows.Visibility.Hidden;

            solid.Base.GaugeBackground = new System.Windows.Media.LinearGradientBrush
            {

                GradientStops = new System.Windows.Media.GradientStopCollection
                {
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.SeaGreen,.5),
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Azure,3),
                new System.Windows.Media.GradientStop (System.Windows.Media.Colors.FloralWhite,1)
                }
            };

            solid.Base.GaugeActiveFill = new System.Windows.Media.LinearGradientBrush
            {

                GradientStops = new System.Windows.Media.GradientStopCollection
                {
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Yellow,.5),
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Red,0),
                new System.Windows.Media.GradientStop (System.Windows.Media.Colors.Blue,1)
                }
            };
        }
   
        public MainForm()
        {
            InitializeComponent();

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }
    }
}
