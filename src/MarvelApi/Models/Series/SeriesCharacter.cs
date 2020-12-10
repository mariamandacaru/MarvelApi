using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class SeriesCharacter
    {
        public int? IdSeries { get; set; }
        public int? IdCharacter { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
