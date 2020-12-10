using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class CharacterStory
    {
        [Key]
        public int? IdCharacter { get; set; }
        public int? IdStories { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Story IdStoriesNavigation { get; set; }
    }
}
