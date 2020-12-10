using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class ComicSummary
    {
        /// <summary>
        /// The path to the individual comic resource.
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        /// The canonical name of the comic.
        /// </summary>
        public string name { get; set; }
    }
}
