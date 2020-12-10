using System;
using System.Collections.Generic;

#nullable disable

namespace MarvelApi.Models
{
    public partial class ComicsCollectedIssue
    {
        public int? IdComic { get; set; }
        public int? IdCollectedIssues { get; set; }

        public virtual CollectedIssue IdCollectedIssuesNavigation { get; set; }
        public virtual Comic IdComicNavigation { get; set; }
    }
}
