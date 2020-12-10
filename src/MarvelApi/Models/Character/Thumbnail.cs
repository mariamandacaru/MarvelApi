using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Thumbnail
    {
        public Thumbnail()
        {
            Characters = new HashSet<Character>();
            Comics = new HashSet<Comic>();
            Events = new HashSet<Event>();
            Series = new HashSet<Series>();
            Stories = new HashSet<Story>();
        }

        public int Id { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Comic> Comics { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
    }
}
