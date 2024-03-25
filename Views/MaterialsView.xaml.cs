using ExperimentalThingsUsingWPF.Data;
using ExperimentalThingsUsingWPF.Models;
using ExperimentalThingsUsingWPF.ViewModels;
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
        public MaterialsViewModel MaterialsViewModel { get; set; }
        public MaterialsView(MaterialsViewModel materialsViewModel)
        {
            InitializeComponent();
            MaterialsViewModel = materialsViewModel;
            DataContext = MaterialsViewModel;
        }

        private async void MaterialsView_Loaded(object sender, RoutedEventArgs e)
        {
            await MaterialsViewModel.OnLoadedAsync();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterByComboBox.Text == "Id")
            {
                var isIdCorrect = int.TryParse(searchTextBox.Text, out int id);
                if (isIdCorrect)
                    materialsGrid.ItemsSource = MaterialsViewModel.Materials.Where(material => material.Id == id);

            }

            else if (filterByComboBox.Text == "Full Name")
                materialsGrid.ItemsSource = MaterialsViewModel.Materials.Where(material => material.FullName.ToLower().Contains(searchTextBox.Text));

            else if (filterByComboBox.Text == "Short Name")
                materialsGrid.ItemsSource = MaterialsViewModel.Materials.Where(material => material.ShortName.ToLower().Contains(searchTextBox.Text));

            else
            {
                var isItId = int.TryParse(searchTextBox.Text, out int id);
                if (isItId)
                    materialsGrid.ItemsSource = MaterialsViewModel.Materials.Where(material => material.Id == id);
                else
                {
                    materialsGrid.ItemsSource = MaterialsViewModel.Materials.Where(material => material.FullName.Contains(searchTextBox.Text)
                                                                            || material.ShortName.Contains(searchTextBox.Text));
                }
            }
        }
    }
}
