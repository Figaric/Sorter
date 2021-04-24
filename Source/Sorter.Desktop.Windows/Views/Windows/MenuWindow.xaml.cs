using System.Windows;

namespace Sorter.Desktop.Windows
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();

            this.DataContext = new MenuWindowViewModel(this);

            PageFrame.Content = new StartUpPage();
        }
    }
}
