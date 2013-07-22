using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
using System.Xml.Serialization;

namespace NewGUI
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=webdb.mdb";
            string query = "Select TOP 1 * From Jobs";
            WebDBDataSet ds = new WebDBDataSet();

            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                conn.Open();
                adapter.Fill(ds.Jobs);
                foreach (var i in ds.Jobs)
                {
                    lbTest.Content = i.Operator;
                }

            }
        }
    }
}
