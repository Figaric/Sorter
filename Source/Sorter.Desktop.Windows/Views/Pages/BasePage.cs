using System.Windows.Controls;

namespace Sorter.Desktop.Windows
{
    public abstract class BasePage<TViewModel> : Page
        where TViewModel : BaseViewModel, new()
    {
        public static TViewModel ViewModel { get; private set; }

        public BasePage()
        {
            ViewModel = new TViewModel();
        }
    }
}
