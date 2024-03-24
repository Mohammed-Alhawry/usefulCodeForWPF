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
using System.Windows.Shapes;

namespace ExperimentalThingsUsingWPF.Windows
{
    /// <summary>
    /// Interaction logic for AddMaterialWindow.xaml
    /// </summary>
    public partial class AddMaterialWindow : Window
    {
        public AddMaterialWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
