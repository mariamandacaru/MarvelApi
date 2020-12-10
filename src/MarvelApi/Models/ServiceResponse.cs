using System;
using System.Threading.Tasks;

namespace MarvelApi.Models
{
    public class ServiceResponse<T>
    {
        /// <summary>
        /// The HTTP status code of the returned result.,
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// A string description of the call status.,
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// The copyright notice for the returned result.,
        /// </summary>
        public string copyright { get; set; }
        /// <summary>
        /// The attribution notice for this result. Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.,
        /// </summary>
        public string attributionText { get; set; }
        /// <summary>
        /// An HTML representation of the attribution notice for this result. Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.
        /// </summary>
        public string attributionHTML { get; set; }
        /// <summary>
        ///  A digest value of the content returned by the call.
        /// </summary>
        public string etag { get; set; }
        /// <summary>
        /// The results returned by the call.,
        /// </summary>
        public DataResponse<T> data { get; set; }
    }
}
