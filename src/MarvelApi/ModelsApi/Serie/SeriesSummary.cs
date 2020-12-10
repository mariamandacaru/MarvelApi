using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class SeriesSummary
    {
        /// <summary>
        /// The path to the individual series resource.
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        /// The canonical name of the series.
        /// </summary>
        public string name { get; set; }
    }
}
