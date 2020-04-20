using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLojaBoa.Models
{
    public class Produto
    {
        public int ProdID { get; set; }
        public string ProdNome { get; set; }
        public float ProdValor { get; set; }
        public int ProdQtd { get; set; }
        public DateTime ProdVencimento { get; set; }

    }
}