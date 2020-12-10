using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class CharacterList
    {
        /// <summary>
        /// The number of total available characters in this list. Will always be greater than or equal to the "returned" value.,
        /// </summary>
        public string available { get; set; }
        /// <summary>
        /// The number of characters returned in this collection (up to 20).,
        /// </summary>
        public string returned { get; set; }
        /// <summary>
        /// The path to the full list of characters in this collection.,
        /// </summary>
        public string collectionURI { get; set; }
        /// <summary>
        /// The list of returned characters in this collection.
        /// </summary>
        public List<CharacterSummary> items { get; set; }
    }
}
