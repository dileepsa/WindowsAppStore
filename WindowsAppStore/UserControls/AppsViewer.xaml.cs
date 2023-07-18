using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsAppStore.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
public partial class AppsViewer : UserControl
    {
        List<AppViewUC> PresentedApps;

        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AppViewUC>();
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 24; i++)
            {
                var app = new AppViewUC();
                PresentedApps.Add(app);
            }
        }

        private void ScrollLeft_Click(object sender, RoutedEventArgs e)
        {
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 400);
        }

        private void ScrollRight_Click(object sender, RoutedEventArgs e)
        {
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 400);

        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = MouseWheelEvent;
            eventArg.Source = eventArg;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArg);
        }
    }
}
