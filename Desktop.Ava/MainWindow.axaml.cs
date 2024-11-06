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

         var   browser = new AvaloniaCefBrowser();
            browser.Address = "https://dev-his.ysmhis.com/his-system-api/middle-web/emr/home";

            browserWrapper.Child = browser;
        }
    }
}