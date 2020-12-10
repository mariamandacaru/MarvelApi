using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesStory
    {
        public int? IdSeries { get; set; }
        public int? IdStories { get; set; }

        public virtual Series IdSeriesNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
