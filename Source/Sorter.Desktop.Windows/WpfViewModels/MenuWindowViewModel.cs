using System;
using System.Windows;
using System.Drawing;
using Sorter.Core;

namespace Sorter.Desktop.Windows
{
    public class MenuWindowViewModel : BaseViewModel
    {
        private readonly MenuWindow _menuWindow;

        #region Inner Padding Thickness

        private readonly int _innerPaddingSize = 10;

        public Thickness InnerPaddingSizeThickness => new Thickness(_menuWindow.WindowState == WindowState.Maximized ? 0 : _innerPaddingSize);

        #endregion

        #region Title Bar Thickness

        private readonly int _titleBarThickness = 30;

        public int CaptionHeight => _titleBarThickness + _innerPaddingSize;

        public string TitleBarThickness => _titleBarThickness + "px";

        #endregion

        public MenuWindowViewModel(MenuWindow menuWindow)
        {
            _menuWindow = menuWindow;
        }
    }
}
