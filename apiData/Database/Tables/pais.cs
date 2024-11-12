using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("pais")]
    public class pais
    {
        [Key]
        public int Id { get; set; }
        [StringLength (50)]
        [Required]
        public string nombre_pais { get; set; }
    }
}
