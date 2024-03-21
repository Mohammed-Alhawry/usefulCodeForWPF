// Ignore Spelling: Dashbored

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
            MainWindow.contentControl.Content = new MaterialsView();
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
    }
}
