using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TopTabControl.TopTabControl
{
    public partial class GroupedDataTemplate : ContentView
    {
        public GroupedDataTemplate()
        {
            InitializeComponent();
            this.BindingContext = new PodcastCollectionViewModel();
            StackList.BindingContext = new PodcastCollectionViewModel();
        }
    }
}
