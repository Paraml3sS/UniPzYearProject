using System.Windows;
using WpfApp.ViewModels;

namespace WpfApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
        }
    }
}
