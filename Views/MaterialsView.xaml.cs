using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.Models;
using System.Windows;
using System.Windows.Controls;

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

        private async void MaterialsView_Loaded(object sender, RoutedEventArgs e)
        {
            materialsGrid.ItemsSource = await GetMaterials();
        }

        private async Task<IEnumerable<Material>> GetMaterials()
        {
            List<Material> materials = new();
            await Task.Run(() =>
            {
                materials = DataProvider.GetMaterials();
            });
            
            return materials;
        }
    }
}
