using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesEvent
    {
        public int? IdSeries { get; set; }
        public int? IdEvents { get; set; }

        public virtual Event IdEventsNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
