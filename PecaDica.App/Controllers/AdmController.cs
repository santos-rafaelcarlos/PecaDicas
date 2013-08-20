using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.LojaServicos;

namespace PecaDica.App.Controllers
{
    public class AdmController : Controller
    {
        public int TamanhoDaPagina = 20;
        //
        // GET: /Adm/
        [HttpGet]
        public ActionResult Index(int pagina = 1, ListaItemViewModel<Loja> viewModel = null)
        {
            IEnumerable<Loja> lojas = Carregalojas();

            viewModel.Items = lojas;
            viewModel.InformacaoDePaginacao = new InformacaoDePaginacao()
            {
                ItensPorPagina = TamanhoDaPagina,
                PaginaAtual = pagina,
                TotalDeItems = 100,
            };

            return View(viewModel);
        }

        private IEnumerable<Loja> Carregalojas()
        {
            return ContextHelper.Contexto.Loja.Cast<>().ToArray();
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Novo(Loja item, FormCollection form)
        {
            ContextHelper.LojaCliente.Open();
            ContextHelper.LojaCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            //todo: passar item
            return View();
        }

        [HttpPost]
        public ActionResult Editar(Loja item)
        {
            //todo: salvar item
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(Guid id)
        {
            //todo: passar item
            return View();
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            //todo: passar item
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Loja item)
        {
            //todo: Deletar
            return RedirectToAction("Index");
        }
    }
}
