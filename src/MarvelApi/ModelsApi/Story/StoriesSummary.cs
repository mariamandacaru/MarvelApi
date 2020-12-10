using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class StoriesSummary
    {
        /// <summary>
        /// The path to the individual story resource.
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        /// The canonical name of the story.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The type of the story (interior or cover).
        /// </summary>
        public string type { get; set; }
    }
}
