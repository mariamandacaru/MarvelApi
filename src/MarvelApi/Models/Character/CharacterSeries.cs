using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class CharacterSeries
    {
        [Key]
        public int? IdCharacter { get; set; }
        public int? IdSeries { get; set; }

        public virtual Character IdCharacterNavigation { get; set; }
        public virtual Series IdSeriesNavigation { get; set; }
    }
}
