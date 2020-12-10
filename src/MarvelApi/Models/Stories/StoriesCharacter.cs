using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class StoriesCharacter
    {
        public int? IdStories { get; set; }
        public int? IdCharacter { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
