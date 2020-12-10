using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of comics containing a specific character
    /// </summary>
    public class ComicResponse
    {
        /// <summary>
        /// The unique ID of the comic resource.
        /// </summary>
        [Key]
        public int id { get; set; }

        /// <summary>
        /// The ID of the digital comic representation of this comic. Will be 0 if the comic is not available digitally.
        /// </summary>
        public int digitalId { get; set; }

        /// <summary>
        /// The canonical title of the comic
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The number of the issue in the series (will generally be 0 for collection formats).
        /// </summary>
        public decimal issueNumber { get; set; }

        /// <summary>
        /// If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant
        /// </summary>
        public string variantDescription { get; set; }

        /// <summary>
        /// The preferred description of the comic
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The date the resource was most recently modified
        /// </summary>
        public DateTime modified { get; set; }

        /// <summary>
        /// The ISBN for the comic (generally only populated for collection formats).
        /// </summary>
        public string isbn { get; set; }

        /// <summary>
        /// The UPC barcode number for the comic (generally only populated for periodical formats).
        /// </summary>
        public string upc { get; set; }

        /// <summary>
        /// The Diamond code for the comic
        /// </summary>
        public string diamondCode { get; set; }

        /// <summary>
        /// The EAN barcode for the comic
        /// </summary>
        public string ean { get; set; }

        /// <summary>
        ///  The ISSN barcode for the comic.
        /// </summary>
        public string issn { get; set; }

        /// <summary>
        /// The publication format of the comic e.g. comic, hardcover, trade paperback
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// The number of story pages in the comic.
        /// </summary>
        public string pageCount { get; set; }

        /// <summary>
        /// A set of descriptive text blurbs for the comic.
        /// </summary>
        public List<TextObject> TextObjects { get; set; }

        /// <summary>
        /// The canonical URL identifier for this resource
        /// </summary>
        public string resourceURI { get; set; }

        /// <summary>
        ///  A set of public web site URLs for the resource.
        /// </summary>
        public List<Url> urls { get; set; }

        /// <summary>
        /// A summary representation of the series to which this comic belongs.
        /// </summary>
        public SeriesSummary series { get; set; }

        /// <summary>
        /// A list of variant issues for this comic (includes the "original" issue if the current issue is a variant)
        /// </summary>
        public List<Variant> variants { get; set; }

        /// <summary>
        /// A list of collections which include this comic (will generally be empty if the comic's format is a collection).
        /// </summary>
        public List<Collection> collections { get; set; }

        /// <summary>
        /// A list of issues collected in this comic (will generally be empty for periodical formats such as "comic" or "magazine").
        /// </summary>
        public List<CollectedIssue> collectedIssues { get; set; }

        /// <summary>
        /// A list of key dates for this comic
        /// </summary>
        public List<Date> dates { get; set; }

        /// <summary>
        ///  A list of prices for this comic.
        /// </summary>
        public List<Price> prices { get; set; }

        /// <summary>
        /// The representative image for this comic.
        /// </summary>
        public Thumbnail Thumbnail { get; set; }

        /// <summary>
        /// A list of promotional images associated with this comic.
        /// </summary>
        public List<Image> Images { get; set; }

        /// <summary>
        /// A resource list containing the creators associated with this comic
        /// </summary>
        public CreatorList creators { get; set; }

        /// <summary>
        ///  A resource list containing the characters which appear in this comic
        /// </summary>
        public CharacterList characters { get; set; }

        /// <summary>
        /// A resource list containing the stories which appear in this comic.
        /// </summary>
        public StoriesList stories { get; set; }

        /// <summary>
        /// A resource list containing the events in which this comic appears
        /// </summary>
        public EventsList events { get; set; }
    }
}
