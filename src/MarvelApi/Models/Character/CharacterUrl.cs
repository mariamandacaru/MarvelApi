using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class CharacterUrl
    {
        public int? IdCharacter { get; set; }
        public int? IdUrl { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Url IdUrlNavigation { get; set; }
    }
}
