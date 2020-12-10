using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsStory
    {
        public int? IdComic { get; set; }
        public int? IdStories { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
