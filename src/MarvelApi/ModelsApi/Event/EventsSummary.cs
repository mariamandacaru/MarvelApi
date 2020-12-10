using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class EventsSummary
    {
        /// <summary>
        /// The path to the individual event resource.
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        /// The name of the event.
        /// </summary>
        public string name { get; set; }
    }
}
