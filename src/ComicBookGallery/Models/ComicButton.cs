using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicButton
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumer { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }
    }
}