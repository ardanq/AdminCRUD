using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace AdminCRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (100)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public int Price { get; set; }

        [Required]
        [DefaultValue("true")]
        public bool Active { get; set; }



    }
}
