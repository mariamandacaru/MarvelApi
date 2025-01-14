﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class DataResponse<T>
    {
        /// <summary>
        /// The requested offset (number of skipped results) of the call.,
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// The requested result limit.,
        /// </summary>
        public int Limit { get; set; }
        /// <summary>
        /// The total number of resources available given the current filter set.,
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// The total number of results returned by this call.,
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// The list of characters returned by the call.
        /// </summary>
        public List<T> Results { get; set; }
    }
}
