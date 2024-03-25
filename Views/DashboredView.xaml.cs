// Ignore Spelling: Dashbored

using ExperimentalThingsUsingWPF.ViewModels;
using ExperimentalThingsUsingWPF.Windows;
using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;

namespace ExperimentalThingsUsingWPF.Views
{
    /// <summary>
    /// Interaction logic for DashboredView.xaml
    /// </summary>
    public partial class DashboredView : UserControl
    {
        public MainWindow MainWindow { get; } = (MainWindow)Application.Current.MainWindow;
        public DashboredView()
        {
            InitializeComponent();
        }

        private void Materials_OnSelected(object sender, RoutedEventArgs e)
        {
            var materialsView = MainWindow?.contentControl?.Content as MaterialsView;
            if (materialsView is null)
                MainWindow.contentControl.Content = new MaterialsView(new MaterialsViewModel());

        }

        private void ThemeSwitch_OnClick(object sender, RoutedEventArgs e)
        {
            var paletteHelper = new PaletteHelper();

            Theme theme = paletteHelper.GetTheme();
            if (theme.GetBaseTheme() == BaseTheme.Light)
                theme.SetDarkTheme();
            else
                theme.SetLightTheme();

            paletteHelper.SetTheme(theme);

        }

        private void Materials_ShowButton_OnClick(object sender, RoutedEventArgs e)
        {
            var materialsView = MainWindow?.contentControl?.Content as MaterialsView;
            if (materialsView is null)
                MainWindow.contentControl.Content = new MaterialsView(new MaterialsViewModel());
        }

        private void Materials_AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            new AddMaterialWindow(new AddMaterialViewModel()).ShowDialog();
        }
    }
}
