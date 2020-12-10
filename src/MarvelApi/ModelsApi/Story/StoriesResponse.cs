using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of comic stories featuring a specific character
    /// </summary>
    public class StoriesResponse
    {
        /// <summary>
        /// The unique ID of the story resource.
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// The story title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///  A short description of the story.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The canonical URL identifier for this resource. 
        /// </summary>
        public string resourceURI { get; set; }

        /// <summary>
        /// The story type e.g. interior story, cover, text story.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///  The date the resource was most recently modified.
        /// </summary>
        public string modified { get; set; }

        /// <summary>
        /// The representative image for this story.
        /// </summary>
        public Thumbnail thumbnail { get; set; }

        /// <summary>
        /// A resource list containing comics in which this story takes place.
        /// </summary>
        public ComicList comics { get; set; }

        /// <summary>
        ///  A resource list containing series in which this story appears.
        /// </summary>
        public SeriesList series { get; set; }

        /// <summary>
        /// A resource list of the events in which this story appears.
        /// </summary>
        public EventsList events { get; set; }

        /// <summary>
        /// A resource list of characters which appear in this story.
        /// </summary>
        public CharacterList characters { get; set; }

        /// <summary>
        /// A resource list of creators who worked on this story.
        /// </summary>
        public CreatorList creators { get; set; }

        /// <summary>
        /// A summary representation of the issue in which this story was originally published.
        /// </summary>
        public StoriesSummary originalIssue { get; set; }
        
    }
}
    