using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WindowsAppStore.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void HomeScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            UIElement element = (UIElement)sender;
            element.Opacity = 0;
            DoubleAnimation animation = new DoubleAnimation()
            {
                From = 0, To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 4))
            };

            element.BeginAnimation(OpacityProperty, animation);
        }
    }
}
