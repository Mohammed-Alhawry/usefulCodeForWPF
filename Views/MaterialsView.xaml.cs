﻿using ExperimentalThingsUsingWPF.Data;
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
        private List<Material> _materials = new();
        public MaterialsView()
        {
            InitializeComponent();
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var searchBox = sender as TextBox;
            searchTextBlock.Visibility = Visibility.Collapsed;
        }


        private async void MaterialsView_Loaded(object sender, RoutedEventArgs e)
        {
            _materials = await GetMaterials();
            materialsGrid.ItemsSource = _materials;
        }

        private async Task<List<Material>> GetMaterials()
        {
            List<Material> materials = new();
            await Task.Run(() =>
            {
                materials = DataProvider.GetMaterials();
            });

            return materials;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            materialsGrid.ItemsSource = _materials.Where(material => material.FullName.Contains(searchTextBox.Text));
        }

        private void SearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBlock.Visibility = Visibility.Visible;
            }
        }

        
    }
}
