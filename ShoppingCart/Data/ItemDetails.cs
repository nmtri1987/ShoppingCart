﻿using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Data
{
    public class ItemDetails
    {
        [Key]
        public int Item_ID { get; set; }

        [Required]
        [Display(Name = "Item_Name")]
        public string Item_Name { get; set; }

        [Required]
        [Display(Name = "Item_Price")]
        public int Item_Price { get; set; }

        [Required]
        [Display(Name = "Image_Name")]
        public string Image_Name { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "AddedBy")]
        public string AddedBy { get; set; }
    }
}
