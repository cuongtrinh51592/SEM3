using ProductManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProductManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Products> Productss;
        public MainPage()
        {
            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/Iphone.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Samsung.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/SamsungZ.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Huawei.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Xiaomi.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/Oppo.jpg" });

            Productss = new ObservableCollection<Products>();
        }

        private void NewProductButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)ImageComboBox.SelectedValue).IconPath;
            Productss.Add(new Products { Product = ProductTextBox.Text, Description = DescriptionTextBox.Text, ImagePath = avatar });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
