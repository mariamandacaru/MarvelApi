using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsCollection
    {
        public int? IdComic { get; set; }
        public int? IdCollection { get; set; }

        public virtual Collection IdCollectionNavigation { get; set; }
        public virtual Comic IdComicNavigation { get; set; }
    }
}
