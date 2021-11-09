using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50,ErrorMessage = "The field Author must be a string with a maximum length of 50")]
        public string Author { get; set; }

        [Range(100,10000,ErrorMessage = "The field PagesNumbers must be between 100 and 10000")]
        public int PagesNumber { get; set; }

        [Column(TypeName = "varchar")]
        public string Publisher { get; set; }

        [Column(TypeName = "varchar")]
        [RegularExpression(
            "[1-31]{2}/[1-12]{2}/[2000-3000]{4}",
            ErrorMessage = "The field PublicationDate must match the regular expression, for example: 02-23-2016")]
        public string PublicationDate { get; set; }

        [Column(TypeName = "varchar")]
        public string Content { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        [Compare("Price", ErrorMessage = "'PriceConfirm' and 'Price' do not match.")]
        public decimal PriceConfirm { get; set; }
    }
}