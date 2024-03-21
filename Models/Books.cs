using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVC_Book_Library.Models
{
    public class Books
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }
        public string? Edition { get; set; }//book editon
        public string? Author {  get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(60)]
        public string? Genre { get; set; }

        //specify the date format:
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime ReleaseDate { get; set; }
        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Added Date"), DataType(DataType.Date)]
        public DateTime AddedDate { get; set;}//the date the book was added to the system
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
//public class Movie
//{
//    public int Id { get; set; }
//    public string? Title { get; set; }
//    [DataType(DataType.Date)]
//    public DateTime ReleaseDate { get; set; }
//    public string? Genre { get; set; }
//    public decimal Price { get; set; }
//}