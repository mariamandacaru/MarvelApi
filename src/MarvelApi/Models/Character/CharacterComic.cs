using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class CharacterComic
    {
        [Key]
        public int IdCharacter { get; set; }
        public int? IdComics { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Comic IdComicsNavigation { get; set; }
    }
}
