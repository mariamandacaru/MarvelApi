using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Comic
    {
        [Key]
        public int Id { get; set; }
        public int? DigitalId { get; set; }
        public string Title { get; set; }
        public string IssueNumber { get; set; }
        public string VariantDescription { get; set; }
        public string Description { get; set; }
        public DateTime? Modified { get; set; }
        public string Isbn { get; set; }
        public string Upc { get; set; }
        public string DiamondCode { get; set; }
        public string Ean { get; set; }
        public string Issn { get; set; }
        public string Format { get; set; }
        public string PageCount { get; set; }
        public string ResourceUri { get; set; }
        public int? Idthumbnail { get; set; }

        public virtual Thumbnail IdthumbnailNavigation { get; set; }
    }
}
