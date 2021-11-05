using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVCBook.Validations;

namespace MVCBook.Models
{
    [Table(name:"Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="Varchar")]
        [MaxLength(50)]
        [CheckValidationsName]
        public string Name { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [CheckValidationsAuthor]
        public string Author { get; set; }
        [CheckValidationsPagesNumber]
        [Range(100, 10000)]
        public int PagesNumber { get; set; }
        public string Publisher { get; set; }
        [Column(TypeName = "Varchar")]
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage ="Ingrese un formato de fecha valido, Por ejemplo: 2017-06-16")]
        
        public string PublicationDate { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Content { get; set; }
        [Column(TypeName = "Money")]        
        public decimal Price { get; set; }
        [Column(TypeName = "Money")]
        [System.ComponentModel.DataAnnotations.Compare("Price")]
        public decimal PriceConfirm { get; set; }
    }
}