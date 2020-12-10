using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsCharacter
    {
        public int? IdComic { get; set; }
        public int? IdCharacter { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Comic IdComicNavigation { get; set; }
    }
}
