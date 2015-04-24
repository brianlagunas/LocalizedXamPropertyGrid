using System.Windows;
using LocalizedXamPropertyGrid.Resources;

namespace LocalizedXamPropertyGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person() { Name = PersonResources.NameValue };
        }
    }
}
