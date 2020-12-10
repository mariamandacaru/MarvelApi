using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsEvent
    {
        public int? IdComic { get; set; }
        public int? IdEvents { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Event IdEventsNavigation { get; set; }
    }
}
