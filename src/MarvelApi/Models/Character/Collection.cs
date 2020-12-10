using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Collection
    {
        public int Id { get; set; }
        public string ResourceUri { get; set; }
        public string Name { get; set; }
    }
}
