using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimatedTileOptionsMenu.Models;
using Xamarin.Forms;

namespace AnimatedTileOptionsMenu
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopulateFeedList();

            FeedList.ItemTapped += FeedList_ItemTapped;
        }

        private void FeedList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null)
            {
                return;
            }
            ((ListView)sender).SelectedItem = null;
        }

        private void PopulateFeedList()
        {
            string imageUrl = "https://66.media.tumblr.com/14a131d8cba27db5ed72774a51cecb7d/tumblr_omtn7uKPxt1w3jldio1_1280.jpg";
            List<FeedItem> feedItems = new List<FeedItem>();
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });
            feedItems.Add(new FeedItem() { Name = "John", ModificationDate = DateTime.Now, ImageUrl = imageUrl });

            FeedList.ItemsSource = feedItems;

        }
    }
}
