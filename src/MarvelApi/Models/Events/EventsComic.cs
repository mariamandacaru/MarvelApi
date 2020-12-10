using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class EventsComic
    {
        public int? IdEvents { get; set; }
        public int? IdComics { get; set; }

        public virtual Comic IdComicsNavigation { get; set; }
        public virtual Event IdEventsNavigation { get; set; }
    }
}
