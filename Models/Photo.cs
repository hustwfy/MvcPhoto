using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPhoto.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Upload Date")]
        [DataType(DataType.Date)]
        public DateTime UpDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal RANK { get; set; }
        public string Rating { get; set; }
    }
}