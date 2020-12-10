using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of comic series in which a specific character appears
    /// </summary>
    public class SeriesResponse
    {
        /// <summary>
        ///  The unique ID of the series resource
        /// </summary>
        [Key]
        public int id { get; set; }
        /// <summary>
        /// The canonical title of the series.,
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// A description of the series.,
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// The canonical URL identifier for this resource
        /// </summary>
        public string resourceURI { get; set; }
        /// <summary>
        /// A set of public web site URLs for the resource.
        /// </summary>
        public List<Url> urls { get; set; }
        /// <summary>
        /// The first year of publication for the series
        /// </summary>
        public string startYear { get; set; }
        /// <summary>
        /// The last year of publication for the series (conventionally, 2099 for ongoing series)
        /// </summary>
        public string endYear { get; set; }
        /// <summary>
        /// The age-appropriateness rating for the series
        /// </summary>
        public string rating { get; set; }
        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        public string modified { get; set; }
        /// <summary>
        /// The representative image for this series
        /// </summary>
        public Thumbnail thumbnail { get; set; }
        /// <summary>
        ///  A resource list containing comics in this series.
        /// </summary>
        public ComicList comics { get; set; }
        /// <summary>
        /// A resource list containing stories which occur in comics in this series
        /// </summary>
        public StoriesList stories { get; set; }
        /// <summary>
        /// A resource list containing events which take place in comics in this series.
        /// </summary>
        public EventsList events { get; set; }
        /// <summary>
        /// A resource list containing characters which appear in comics in this series.
        /// </summary>
        public CharacterList characters { get; set; }
        /// <summary>
        /// A resource list of creators whose work appears in comics in this series.
        /// </summary>
        public CreatorList creators { get; set; }
        /// <summary>
        ///  A summary representation of the series which follows this series.
        /// </summary>
        public SeriesSummary next { get; set; }
        /// <summary>
        ///  A summary representation of the series which preceded this series.
        /// </summary>
        public SeriesSummary previous { get; set; }
        
    }
}
