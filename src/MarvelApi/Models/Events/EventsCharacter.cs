using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class EventsCharacter
    {
        public int? IdEvents { get; set; }
        public int? IdCharacter { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Event IdEventsNavigation { get; set; }
    }
}
