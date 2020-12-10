using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsUrl
    {
        public int? IdComic { get; set; }
        public int? IdUrl { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Url IdUrlNavigation { get; set; }
    }
}
