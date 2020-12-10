using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Creator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string ResourceUri { get; set; }
    }
}
