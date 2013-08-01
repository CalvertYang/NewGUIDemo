using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Charts;

namespace NewGUI
{
    /// <summary>
    /// Map.xaml 的互動邏輯
    /// </summary>
    public partial class Map : UserControl
    {
        ChartControl chart;

        public Map()
        {
            InitializeComponent();

            // Initialize chart control
            InitialChart();
        }

        #region Action

        private void btnMapSetting_Click(object sender, RoutedEventArgs e)
        {
            MapSettings mapSettings = new MapSettings();
            mapSettings.ShowDialog();
        }

        private void chart_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void chart_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Method

        private void InitialChart()
        {
            chart = defectMap;

            // 關閉十字瞄準游標
            chart.CrosshairEnabled = false;

            // 綁定事件
            //chart.CustomDrawSeriesPoint += chart_CustomDrawSeriesPoint;
            chart.MouseMove += chart_MouseMove;
            chart.MouseDoubleClick += chart_MouseDoubleClick;

            // 定義圖表類型
            XYDiagram2D diagram = new XYDiagram2D();

            // 設定坐標軸最小/最大值、格線類型及刻度
            diagram.AxisX = new AxisX2D();
            diagram.AxisX.Range = new AxisRange();
            diagram.AxisX.Range.MinValue = 0;
            //diagram.AxisX.Range.MaxValue = 60;
            diagram.AxisX.GridLinesLineStyle = new LineStyle();
            diagram.AxisX.GridLinesLineStyle.DashStyle = DashStyles.Dash;
            diagram.AxisX.GridSpacing = 1;
            diagram.AxisX.TickmarksMinorVisible = false;

            diagram.AxisY = new AxisY2D();
            diagram.AxisY.Range = new AxisRange();
            diagram.AxisY.Range.MinValue = 0;
            //diagram.AxisY.Range.MaxValue = 60;
            diagram.AxisY.GridLinesLineStyle = new LineStyle();
            diagram.AxisY.GridLinesLineStyle.DashStyle = DashStyles.Dash;
            diagram.AxisY.GridSpacing = 1;
            diagram.AxisY.TickmarksMinorVisible = false;

            chart.Diagram = diagram;
        }

        #endregion
    }
}
