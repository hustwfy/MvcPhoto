
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPhoto.Models
{
    public class PhotoGenreViewModel
    {
        public List<Photo> Photos { get; set; }
        public SelectList Genres { get; set; }
        public string PhotoGenre { get; set; }
        public string SearchString { get; set; }
    }
}