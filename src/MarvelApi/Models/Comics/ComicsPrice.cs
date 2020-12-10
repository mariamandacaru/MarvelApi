using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsPrice
    {
        public int? IdComic { get; set; }
        public int? IdPrices { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Price IdPricesNavigation { get; set; }
    }
}
