using AppLojaBoa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppLojaBoa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cliente()
        {
            Cliente cliente = new Cliente()
            {
                CliId = 23,
                CliNome = "Gizcreuza",
                CliNasc = Convert.ToDateTime("23/05/1996"),
                CliEnd = "Rua Tá Difícil, 00"
            };
            return View(cliente);
        }

        public ActionResult Produto()
        {
            Produto produto = new Produto()
            {
                ProdID = 1,
                ProdNome = "Bom",
                ProdValor = 149.99f,
                ProdQtd = 100,
                ProdVencimento = Convert.ToDateTime("07/03/1029")
            };
            return View(produto);
        }

        public ActionResult Venda()
        {
            Venda venda = new Venda()
            {
                VendaId = 100,
                VendaData = Convert.ToDateTime("2019-02-28"),
                VendaTotal = 500
            };
            return View(venda);
        }

        public ActionResult Aluno()
        {
            return View();
        }
    }
}