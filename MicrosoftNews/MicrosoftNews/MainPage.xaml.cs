using MicrosoftNews.Models;
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

namespace MicrosoftNews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<MenuItem> MenuItems;

        private ObservableCollection<News> News;

        private List<String> Suggestions;

        public MainPage()
        {
            this.InitializeComponent();
            News = new ObservableCollection<News>();
            NewsManager.GetAllNews(News);
            MenuItems = new List<MenuItem>();
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/Sport.png", Category = NewsCategory.Sport });
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/Business.png", Category = NewsCategory.Business });
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/Heath.png", Category = NewsCategory.Heath });
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/Hitech.png", Category = NewsCategory.Hitech });
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/Showbiz.png", Category = NewsCategory.Showbiz });
            MenuItems.Add(new MenuItem { IconFile = "Assets/Icons/TheWorld.png", Category = NewsCategory.TheWorld });

        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            goBack();
        }

        

        private void MenuItemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = (MenuItem)e.ClickedItem;

            CategoryTextBlock.Text = menuItem.Category.ToString();
            NewsManager.GetNewsByCategory(News, menuItem.Category);
            BackButton.Visibility = Visibility.Visible;

        }

        private void SearchAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            NewsManager.GetAllNews(News);
            Suggestions = News.Where(p => p.Name.StartsWith(sender.Text)).Select(p => p.Name).ToList();
            SearchAutoSuggestBox.ItemsSource = Suggestions;
        }

        private void SearchAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            NewsManager.GetNewsByName(News, sender.Text);
            CategoryTextBlock.Text = sender.Text;
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Visible;

            if (String.IsNullOrEmpty(sender.Text)) goBack();
        }

        private void goBack()
        {
            NewsManager.GetAllNews(News);
            CategoryTextBlock.Text = "All News";
            MenuItemsListView.SelectedItem = null;
            BackButton.Visibility = Visibility.Collapsed;
        }

        private void NewsGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var news = (News)e.ClickedItem;
        }
    }
}
