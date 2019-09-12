using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Test.Models
{
    public class ProductViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
       
        public string Description { get; set; }
       
        public enum Size { S =1, M = 2, L = 3 }

        public Size SizeId { get; set; }
        
        [Required]
        public int Price { get; set; }
    }
}