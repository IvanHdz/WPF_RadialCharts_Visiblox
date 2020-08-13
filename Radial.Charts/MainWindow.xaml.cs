using System.Collections.Generic;
using System.Windows;

namespace Radial.Charts
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Dictionary<string, double> { { "A", 8.167 }, { "E", 12.702 }, { "I", 6.966 }, { "O", 7.507 }, { "U", 2.758 } };
        }
    }
}