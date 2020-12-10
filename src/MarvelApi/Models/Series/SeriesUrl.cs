using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesUrl
    {
        public int? IdSeries { get; set; }
        public int? IdUrl { get; set; }

        public virtual Series IdSeriesNavigation { get; set; }
        public virtual Url IdUrlNavigation { get; set; }
    }
}
