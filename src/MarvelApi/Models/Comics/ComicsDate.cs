using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsDate
    {
        public int? IdComic { get; set; }
        public int? IdDates { get; set; }

        public virtual Comic IdComicNavigation { get; set; }
        public virtual Date IdDatesNavigation { get; set; }
    }
}
