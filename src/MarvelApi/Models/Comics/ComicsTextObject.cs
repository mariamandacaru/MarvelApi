using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsTextObject
    {
        public int? IdComic { get; set; }
        public int? IdTextObject { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual TextObject IdTextObjectNavigation { get; set; }
    }
}
