using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace ExperimentalThingsUsingWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            CultureInfo.CurrentUICulture = new CultureInfo("ar");
            var flowDirection = CultureInfo.CurrentUICulture.Name.StartsWith("ar") ? FlowDirection.RightToLeft : FlowDirection.LeftToRight;
            FrameworkElement.FlowDirectionProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(flowDirection));

            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }

}
