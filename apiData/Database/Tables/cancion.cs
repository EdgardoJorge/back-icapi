using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.Tables
{
    [Table("cancion")]
    public class cancion
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string nombre_Cancion { get; set; }
        public int id_album { get; set; }
    }
}
