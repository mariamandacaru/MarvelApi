using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MarvelApi.Models
{
    public class Items
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string resourceURI { get; set; }
    }
}
