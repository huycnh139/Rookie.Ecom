﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 250)]
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
