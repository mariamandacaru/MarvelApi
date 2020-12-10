using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesComic
    {
        public int? IdSeries { get; set; }
        public int? IdComics { get; set; }

        public virtual Comic IdComicsNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
