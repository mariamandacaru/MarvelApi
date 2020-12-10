using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class ComicList
    {
        /// <summary>
        /// The number of total available issues in this list. Will always be greater than or equal to the "returned" value.
        /// </summary>
        public int available { get; set; }
        /// <summary>
        /// The number of issues returned in this collection (up to 20).
        /// </summary>
        public int returned { get; set; }
        /// <summary>
        /// The path to the full list of issues in this collection.
        /// </summary>
        public string collectionURI { get; set; }
        /// <summary>
        /// The list of returned issues in this collection.
        /// </summary>
        public List<ComicSummary> items { get; set; }
    }
}
