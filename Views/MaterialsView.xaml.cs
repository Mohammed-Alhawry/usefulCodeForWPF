using ExperimentalThingsUsingWPF.Data;
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

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for MaterialsView.xaml
    /// </summary>
    public partial class MaterialsView : UserControl
    {
        public MaterialsView()
        {
            InitializeComponent();
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var searchBox = sender as TextBox;
            if (searchBox.Text == "Search...")
                searchBox.Text = "";

        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var searchBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(searchBox.Text))
                searchBox.Text = "Search...";
        }

        private void MaterialsView_Loaded(object sender, RoutedEventArgs e)
        {
            materialsGrid.ItemsSource = DataProvider.GetMaterials();
        }
    }
}
