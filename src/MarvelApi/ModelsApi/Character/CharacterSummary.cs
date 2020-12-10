using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class CharacterSummary
    {
        /// <summary>
        /// The path to the individual character resource.
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        ///  The full name of the character.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The role of the creator in the parent entity
        /// </summary>
        public string role { get; set; }
    }
}
