using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Story
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceUri { get; set; }
        public string Type { get; set; }
        public DateTime? Modified { get; set; }
        public int? Idthumbnail { get; set; }

        public virtual Thumbnail IdthumbnailNavigation { get; set; }
    }
}
