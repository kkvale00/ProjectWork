using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _00___ProjectWorkTest1.Models
{
    public class Quantita
    {
        //[Key, Column(Order = 1), ForeignKey("taglie")] //check if taglie ok, or try taglie(id)


        public int TagliaId { get; set; }
        public int ColoreId { get; set; }
        public int ProdottoId { get; set; }
        public int Quantitativo { get; set; }

        public Prodotto Prodotti { get; set; }
        public Colore Colori { get; set; }
        public Taglia Taglie { get; set; }






    }
}
