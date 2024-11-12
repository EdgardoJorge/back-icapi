using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("album")]
    public class album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre_Album { get; set; }
        public int id_banda { get; set; }
    }
}
