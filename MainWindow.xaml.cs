using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using ExperimentalThingsUsingWPF.Windows;
using MaterialDesignThemes.Wpf;
namespace ExperimentalThingsUsingWPF;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }

    private void MainWindow_StateChanged(object sender, EventArgs e)
    {
        if(this.WindowState == WindowState.Maximized)
        {            
            this.MaxWidth = SystemParameters.WorkArea.Height;
            this.MaxWidth = SystemParameters.WorkArea.Width;
        }
    }

    private void Window_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove();   
        }
    }


}