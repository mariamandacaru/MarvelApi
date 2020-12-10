using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class CreatorList
    {
        /// <summary>
        ///  The number of total available creators in this list. Will always be greater than or equal to the "returned" value.
        /// </summary>
        public string available { get; set; }
        /// <summary>
        ///  The number of creators returned in this collection (up to 20).
        /// </summary>
        public string returned { get; set; }
        /// <summary>
        /// The path to the full list of creators in this collection.
        /// </summary>
        public string collectionURI { get; set; }
        /// <summary>
        /// The list of returned creators in this collection.
        /// </summary>
        public List<CreatorSummary> items { get; set; }
    }
}
