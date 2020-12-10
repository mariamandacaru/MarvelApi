using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class CharacterEvent
    {
        [Key]
        public int? IdCharacter { get; set; }
        public int? IdEvents { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Event IdEventsNavigation { get; set; }
    }
}
