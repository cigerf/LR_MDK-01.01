using ClassLibrary1;
using ClassLibrary1.Views;
using LiveCharts;
using LiveCharts.Wpf;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;

namespace ChartTest.Views
{
    public class SalesCartesianChart : LiveCharts.WinForms.CartesianChart,
                                       ISalesView
    {
        private LineSeries seriesData_;
        public SalesCartesianChart()
        {
            seriesData_ = new LineSeries
            {
                Title = "Продажи",

                Stroke = new SolidColorBrush(Colors.Blue),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                        System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                        System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                        90)
            };

            /// Ось Y
            AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },

                MinValue = 0
            }
            );


            /// Ось X
            AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }
        public void Show(List<Sale> sales)
        {
            if (sales == null || sales.Count == 0) return;

            var X = AxisX[0];
            var Y = AxisY[0];

            {
                int maxValue = sales.Max(sale => sale.Count);
                Y.MaxValue = maxValue + 1;
            }

            X.Labels = new string[sales.Count];
            seriesData_.Values = new ChartValues<int>();
            for (int index = 0; index < sales.Count; ++index)
            {
                X.Labels[index] = sales[index].Date.ToShortDateString();
                seriesData_.Values.Add(sales[index].Count);
            }

            Series = new SeriesCollection { seriesData_ };
        }
    }
}
