using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceUri { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Idthumbnail { get; set; }

        public virtual Thumbnail IdthumbnailNavigation { get; set; }
    }
}
