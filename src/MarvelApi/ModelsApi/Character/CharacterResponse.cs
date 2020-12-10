using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of comic characters 
    /// </summary>
    public class CharacterResponse
    {
        /// <summary>
        /// The unique ID of the character resource.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  The name of the character.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// A short bio or description of the character.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        public DateTime Modified { get; set; }
        /// <summary>
        /// The canonical URL identifier for this resource.
        /// </summary>
        public string ResourceURI { get; set; }
        /// <summary>
        /// A set of public web site URLs for the resource.
        /// </summary>
        public List<Url> Urls { get; set; }
        /// <summary>
        /// The representative image for this character.
        /// </summary>
        public Thumbnail Thumbnail { get; set; }
        /// <summary>
        /// A resource list containing comics which feature this character.
        /// </summary>
        public ComicList Comics { get; set; }
        /// <summary>
        /// A resource list of stories in which this character appears.
        /// </summary>
        public StoriesList Stories { get; set; }
        /// <summary>
        /// A resource list of events in which this character appears.
        /// </summary>
        public EventsList Events { get; set; }
        /// <summary>
        /// A resource list of series in which this character appears.
        /// </summary>
        public SeriesList Series { get; set; }
   
    }
}
