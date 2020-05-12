using System;
namespace TopTabControl.TopTabControl
{
    public class Podcast
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public PodcastCellType CellType { get; set; }
    }

    public enum PodcastCellType
    {
        Standard,
        New,
        Personalized
    }
}
