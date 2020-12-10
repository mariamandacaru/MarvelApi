using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class EventsCreator
    {
        public int? IdEvents { get; set; }
        public int? IdCreator { get; set; }

        public virtual Creator IdCreatorNavigation { get; set; }
        public virtual Event IdEventsNavigation { get; set; }
    }
}
