using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of events in which a specific character appears.
    /// </summary>
    public class EventsResponse
    {
        /// <summary>
        /// The unique ID of the event resource
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// The title of the event.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// A description of the event.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The canonical URL identifier for this resource.
        /// </summary>
        public string resourceURI { get; set; }

        /// <summary>
        /// A set of public web site URLs for the event
        /// </summary>
        public List<Url> urls { get; set; }

        /// <summary>
        /// The date the resource was most recently modified
        /// </summary>
        public string modified { get; set; }

        /// <summary>
        /// The date of publication of the first issue in this event.
        /// </summary>
        public string start { get; set; }

        /// <summary>
        /// The date of publication of the last issue in this event.
        /// </summary>
        public string end { get; set; }

        /// <summary>
        ///  The representative image for this event.
        /// </summary>
        public Thumbnail thumbnail { get; set; }

        /// <summary>
        /// A resource list containing the comics in this event.
        /// </summary>
        public ComicList comics { get; set; }

        /// <summary>
        /// A resource list containing the stories in this event.
        /// </summary>
        public StoriesList stories { get; set; }

        /// <summary>
        /// A resource list containing the series in this event.
        /// </summary>
        public SeriesList series { get; set; }

        /// <summary>
        ///  A resource list containing the characters which appear in this event
        /// </summary>
        public CharacterList characters { get; set; }

        /// <summary>
        /// A resource list containing creators whose work appears in this event.
        /// </summary>
        public CreatorList creators { get; set; }

        /// <summary>
        /// A summary representation of the event which follows this event.
        /// </summary>
        public EventsSummary next { get; set; }

        /// <summary>
        /// A summary representation of the event which preceded this event.
        /// </summary>
        public EventsSummary previous { get; set; }
  
    }
}
