using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class EventsList
    {
        /// <summary>
        /// The number of total available events in this list. Will always be greater than or equal to the "returned" value.
        /// </summary>
        public int available { get; set; }
        /// <summary>
        /// The number of events returned in this collection (up to 20).
        /// </summary>
        public int returned { get; set; }
        /// <summary>
        /// The path to the full list of events in this collection.
        /// </summary>
        public string collectionURI { get; set; }
        /// <summary>
        /// The list of returned events in this collection.
        /// </summary>
        public List<EventsSummary> items { get; set; }
    }
}
