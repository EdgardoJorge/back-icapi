using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("artista")]
    public class artista
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string apellidos { get; set; }
        [Required]
        [StringLength(50)]
        public string nombres { get; set; }
        [Required]
        public DateTime fecha_Nacimiento { get; set; }
        public int vivo { get; set;}
        public int id_pais { get; set;}
        public int id_banda { get; set;}

    }
}
