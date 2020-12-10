using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsVariant
    {
        public int? IdComic { get; set; }
        public int? IdVariant { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Variant IdVariantNavigation { get; set; }
    }
}
