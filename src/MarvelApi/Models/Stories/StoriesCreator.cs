using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class StoriesCreator
    {
        public int? IdStories { get; set; }
        public int? IdCreator { get; set; }

        public virtual Creator IdCreatorNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
