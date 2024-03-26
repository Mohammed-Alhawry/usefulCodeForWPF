using ExperimentalThingsUsingWPF.ViewModels;
using System.Windows;

namespace ExperimentalThingsUsingWPF.Windows
{
    /// <summary>
    /// Interaction logic for EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        public EditUserWindow(EditUserViewModel editUserViewModel)
        {
            InitializeComponent();
            DataContext = editUserViewModel;
        }
    }
}
