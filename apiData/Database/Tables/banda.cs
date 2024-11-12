using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("banda")]
    public class banda
    {
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string nombre_banda { get; set; }
        public int id_genero { get; set; }
    }
}
