using apiData.Database.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiData.Database.seeds
{
    internal class seeds
    {
        public static void seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cancion>().HasData(
                new cancion
                {
                    Id = 1,
                    nombre_Cancion = "jdiejdiejde",
                    id_album= 1
                }
                ) ;

            
        }
    }
}
