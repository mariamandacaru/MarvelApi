using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class StoriesEvent
    {
        public int? IdStories { get; set; }
        public int? IdEvents { get; set; }

        public virtual Event IdEventsNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
