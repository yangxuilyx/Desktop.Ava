using Avalonia.Controls;
using Xilium.CefGlue.Avalonia;

namespace Desktop.Ava
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var browserWrapper = this.FindControl<Decorator>("browserWrapper");

            var browser = new AvaloniaCefBrowser();
            browser.Address = "https://www.google.com";

            browserWrapper.Child = browser;
        }
    }
}