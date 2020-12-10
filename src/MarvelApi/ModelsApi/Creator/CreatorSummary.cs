using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class CreatorSummary
    {
        /// <summary>
        /// The path to the individual creator resource
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        ///  The full name of the creator.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///  The role of the creator in the parent entity
        /// </summary>
        public string role { get; set; }
    }
}
