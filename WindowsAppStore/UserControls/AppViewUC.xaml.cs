using MiscUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for AppViewUC.xaml
    /// </summary>
    public partial class AppViewUC : UserControl
    {
        public static string AppName;
        public static ImageSource imageSource;

        public AppViewUC()
        {
            InitializeComponent();
            List<string> filePaths = Directory.GetFiles(Environment.CurrentDirectory + @"\Images", "*.png").ToList();
            FileInfo fileInfo = new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);
            AppNameText.Text = GetAppName(fileInfo.FullName);
            ProductImage.Source = new BitmapImage(new Uri(fileInfo.FullName, UriKind.RelativeOrAbsolute));
            imageSource = ProductImage.Source;
            AppName = AppNameText.Text;
        }

        private string GetAppName(string fullName)
        {
            return fullName.Split('\\').Last().Split('-').Last().Split('.').First();
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
