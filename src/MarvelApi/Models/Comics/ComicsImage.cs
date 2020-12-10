using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsImage
    {
        public int? IdComic { get; set; }
        public int? IdImages { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Image IdImagesNavigation { get; set; }
    }
}
