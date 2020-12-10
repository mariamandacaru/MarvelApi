using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class StoriesComic
    {
        public int? IdStories { get; set; }
        public int? IdComics { get; set; }

        public virtual Comic IdComicsNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
