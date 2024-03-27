using ExperimentalThingsUsingWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for ClinicsView.xaml
    /// </summary>
    public partial class ClinicsView : UserControl
    {
        private readonly ClinicsViewModel _clinicsViewModel;
        public ClinicsView(ClinicsViewModel clinicsViewModel)
        {
            InitializeComponent();
            _clinicsViewModel = clinicsViewModel;
            DataContext = _clinicsViewModel;
            Loaded += ClinicsView_OnLoadedAsync;
        }

        private async void ClinicsView_OnLoadedAsync(object sender, RoutedEventArgs e)
        {
            await _clinicsViewModel.OnLoadedAsync();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (filterByComboBox.Text == Translations.Translations.Id)
            {
                var isIdCorrect = int.TryParse(searchTextBox.Text, out int id);
                if (isIdCorrect)
                    clinicsGrid.ItemsSource = _clinicsViewModel.Clinics.Where(clinic => clinic.Id == id);

            }

            else if (filterByComboBox.Text == Translations.Translations.Name)
                clinicsGrid.ItemsSource = _clinicsViewModel.Clinics.Where(clinic => clinic.Name.ToLower().Contains(searchTextBox.Text.ToLower()));

            else if (filterByComboBox.Text == Translations.Translations.Address)
                clinicsGrid.ItemsSource = _clinicsViewModel.Clinics.Where(clinic => clinic.Address.ToLower().Contains(searchTextBox.Text.ToLower()));

            else
            {
                var isItId = int.TryParse(searchTextBox.Text, out int id);
                if (isItId)
                    clinicsGrid.ItemsSource = _clinicsViewModel.Clinics.Where(clinic => clinic.Id == id);
                else
                {
                    clinicsGrid.ItemsSource = _clinicsViewModel.Clinics.Where(clinic => clinic.Name.Contains(searchTextBox.Text)
                                                                            || clinic.Address.Contains(searchTextBox.Text));
                }
            }
        }
    }
}
