using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    [Flags]
    public enum OrderResult
    {
        [Description("name")]
        NameAscending = 0x00,

        [Description("modified")]
        ModifiedAscending = 0x01,

        [Description("-name")]
        NameDescending = 0x02,

        [Description("-modified")]
        ModifiedDescending = 0x04
    }
    public abstract class BaseFilter
    {
        /// <summary>
        /// Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed.
        /// </summary>
        public OrderResult OrderBy { get; set; }

        /// <summary>
        /// Limit the result set to the specified number of resources.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Skip the specified number of resources in the result set.
        /// </summary>
        public int? Offset { get; set; }
    }
}
