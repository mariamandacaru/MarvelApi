using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsCreator
    {
        public int? IdComic { get; set; }
        public int? IdCreator { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Creator IdCreatorNavigation { get; set; }
    }
}
