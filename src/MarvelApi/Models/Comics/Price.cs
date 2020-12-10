using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal? price { get; set; }
    }
}
