using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Load_Order_Desktop_Utility.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
