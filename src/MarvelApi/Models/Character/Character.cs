using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Modified { get; set; }
        public string ResourceUri { get; set; }
        public int? Idthumbnail { get; set; }

        public virtual Thumbnail IdthumbnailNavigation { get; set; }
    }
}
