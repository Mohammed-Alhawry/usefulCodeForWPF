using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.Windows;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for MaterialsView.xaml
    /// </summary>
    public partial class MaterialsView : UserControl
    {
        private ObservableCollection<MaterialModel> _materials = new();
        public MaterialsView()
        {
            InitializeComponent();
        }



        private async void MaterialsView_Loaded(object sender, RoutedEventArgs e)
        {
            _materials = await GetMaterials();
            materialsGrid.ItemsSource = _materials;
        }

        private async Task<ObservableCollection<MaterialModel>> GetMaterials()
        {
            ObservableCollection<MaterialModel> materials = new();
            await Task.Run(() =>
            {
                materials = DataProvider.GetMaterials();
            });

            return materials;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterByComboBox.Text == "Id")
            {
                var isIdCorrect = int.TryParse(searchTextBox.Text, out int id);
                if (isIdCorrect)
                    materialsGrid.ItemsSource = _materials.Where(material => material.Id == id);

            }

            else if (filterByComboBox.Text == "Full Name")
                materialsGrid.ItemsSource = _materials.Where(material => material.FullName.Contains(searchTextBox.Text));

            else if (filterByComboBox.Text == "Short Name")
                materialsGrid.ItemsSource = _materials.Where(material => material.ShortName.Contains(searchTextBox.Text));

            else
            {
                var isItId = int.TryParse(searchTextBox.Text, out int id);
                if (isItId)
                    materialsGrid.ItemsSource = _materials.Where(material => material.Id == id);
                else
                {
                    materialsGrid.ItemsSource = _materials.Where(material => material.FullName.Contains(searchTextBox.Text) 
                                                                            || material.ShortName.Contains(searchTextBox.Text));
                }
            }
        }

        private void AddMaterialButton_OnClick(object sender, RoutedEventArgs e)
        {
            new AddMaterialWindow().ShowDialog();
        }
    }
}
