using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLojaBoa.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public DateTime VendaData { get; set; }
        public float VendaTotal { get; set; }
    }
}