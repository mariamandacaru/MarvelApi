using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class TextObject
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Text { get; set; }
    }
}
