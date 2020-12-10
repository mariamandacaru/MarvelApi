using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsSeries
    {
        public int? IdComic { get; set; }
        public int? IdSeries { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
