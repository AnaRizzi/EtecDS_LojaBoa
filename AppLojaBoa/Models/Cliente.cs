using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLojaBoa.Models
{
    public class Cliente
    {
        public int CliId { get; set; }
        public string CliNome { get; set; }
        public string CliEnd { get; set; }
        public DateTime CliNasc { get; set; }

    }
}