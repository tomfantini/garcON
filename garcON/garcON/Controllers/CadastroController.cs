using garcON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace garcON.Controllers
{
    public class CadastroController : Controller
    {

        private readonly garcONEntities context = new garcONEntities();

        // GET: Cadastro
        public ActionResult Cadastro()
        {
            return View(context.TB_PESSOA.ToList());
        }
    }
}