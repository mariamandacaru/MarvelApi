using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesCreator
    {
        public int? IdSeries { get; set; }
        public int? IdCreator { get; set; }

        public virtual Creator IdCreatorNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
