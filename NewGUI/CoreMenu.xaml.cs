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
using System.Windows.Shapes;

namespace NewGUI
{
    /// <summary>
    /// CoreMenu.xaml 的互動邏輯
    /// </summary>
    public partial class CoreMenu : Window
    {
        public CoreMenu()
        {
            InitializeComponent();
        }

        private void stopJob_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Job Stop!!");
        }

        private void pauseJob_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Job Pause!!");
        }

        private void startJob_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MessageBox.Show("Job Start!!");
        }
    }
}
