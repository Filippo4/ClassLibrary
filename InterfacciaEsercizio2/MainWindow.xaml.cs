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

namespace InterfacciaEsercizio2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_calcola_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(txt_num.Text);
            double srq = Math.Sqrt(num);
            lbl_risposta.Content = $"la radice del numero {num} è {srq}!";
        }
    }
}
