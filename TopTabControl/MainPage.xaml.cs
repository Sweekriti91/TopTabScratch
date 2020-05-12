using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopTabControl.TopTabControl;
using Xamarin.Forms;

namespace TopTabControl
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var tabsList = new List<TitleTab>()
            {
                new TitleTab(){ TitleName = "LIST #1"},
                new TitleTab(){ TitleName = "LIST #2"},
                new TitleTab(){ TitleName = "LIST #3"}
            };

            BottomContentView.ItemsSource = tabsList;
            TopButtonsView.ItemsSource = tabsList;

        }

        void TopButtonsView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            UpdateSelectionDataAsync(e.PreviousSelection, e.CurrentSelection);
            ((CollectionView)sender).SelectedItem = null; //deselect row
        }

        async Task UpdateSelectionDataAsync(IEnumerable<object> previousSelection, IEnumerable<object> currentSelection)
        {
            var selected = (currentSelection.FirstOrDefault() as TitleTab);
            if (selected == null)
                return;

            if(selected.TitleName.Equals("LIST #2"))
            {
                BottomContentView.ScrollTo(1, position: ScrollToPosition.Center);
                TopButtonsView.ScrollTo(1, position: ScrollToPosition.Center);
            }

            if (selected.TitleName.Equals("LIST #3"))
            {
                BottomContentView.ScrollTo(2, position: ScrollToPosition.Center);
                TopButtonsView.ScrollTo(2, position: ScrollToPosition.Center);
            }

            if (selected.TitleName.Equals("LIST #1"))
            {
                BottomContentView.ScrollTo(0, position: ScrollToPosition.Center);
                TopButtonsView.ScrollTo(0, position: ScrollToPosition.Center);
            }
        }
    }

    public class TitleTab
    {
       public string TitleName { get; set; }
    }

    public class GroupPodcast : List<Podcast>
    {
        public string GroupName { get; set; }

        public GroupPodcast(string groupName, IList<Podcast> podcasts)
        {
            GroupName = groupName;
            AddRange(podcasts);
        }
    }
}
