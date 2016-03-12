﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(255)]
        public string PictureSource { get; set; }

        [MaxLength(35)]
        public string Pseudonym { get; set; }

        public bool UsePseudonym { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }
        
        public virtual ICollection<Work> Works { get; set; }

    }
}
