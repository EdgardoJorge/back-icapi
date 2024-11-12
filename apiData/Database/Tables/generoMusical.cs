﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("generoMusical")]
    public class generoMusical
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre_genero { get; set; }
    }
}