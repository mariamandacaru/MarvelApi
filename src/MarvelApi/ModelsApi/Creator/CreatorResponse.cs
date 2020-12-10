using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MarvelApi.Models
{
    /// <summary>
    /// Fetches lists of comic creators 
    /// </summary>
    public class CreatorResponse
    {
        /// <summary>
        /// The unique ID of the creator resource
        /// </summary>
        [Key]
        public int id { get; set; }
        /// <summary>
        /// The first name of the creator
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The role of the creator in the parent entity.
        /// </summary>
        public string role { get; set; }
        /// <summary>
        ///  The path to the individual creator resource.
        /// </summary>
        public string resourceUri { get; set; }
    }
}
