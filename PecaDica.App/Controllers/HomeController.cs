using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.PecaDicaServicos;

namespace PecaDica.App.Controllers
{
    public class HomeController : Controller
    {
        public int TamanhoDaPagina = 20;
        
        //
        // GET: /Home/        
        [HttpGet]
        public ActionResult Index(int pagina = 1)
        {
            ListaItemViewModel<Produto>
                viewModel = new ListaItemViewModel<Produto>();

            CarregaMarcas(Session["Marca"] as Marca);
            if (Session["Marca"] != null)
                CarregaModelo(Session["Marca"] as Marca, Session["Modelo"] as Modelo);
            else
                ViewBag.Modelos = new SelectList(new Modelo[] { });

            IEnumerable<Produto> produtos = CarregaProduto(Session["Modelo"] as Modelo);

            viewModel.Items = produtos;
            viewModel.InformacaoDePaginacao = new InformacaoDePaginacao()
            {
                ItensPorPagina = TamanhoDaPagina,
                PaginaAtual = pagina,
                TotalDeItems = ContextHelper.Contexto.Produto.Count(),
            };
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ListaItemViewModel<Produto> viewModel, FormCollection form)
        {
            Guid marcaID = Guid.Empty;
            Guid modeloID = Guid.Empty;

            if (Guid.TryParse(form["Marcas"], out marcaID))
                //&& (Session["Marca"] == null || (Session["Marca"] as Marca).Id != marcaID))
                Session["Marca"] = ContextHelper.Contexto
                    .Marca.Where(m => m.Id == marcaID).FirstOrDefault();

            if (Guid.TryParse(form["Modelos"], out modeloID))
                //&& (Session["Modelo"] == null || (Session["Modelo"] as Modelo).Id != modeloID))
                Session["Modelo"] = ContextHelper.Contexto
                    .Modelo.Where(m => m.Id == modeloID).FirstOrDefault();

            return RedirectToAction("Index", viewModel);
        }

        private IEnumerable<Produto> CarregaProduto(Modelo modelo = null)
        {
            IEnumerable<Produto> produtos = new Produto[] { };

            if (modelo != null)
                produtos = ContextHelper.Contexto
                    .Produto.Where(p => p.Modelo.Id == modelo.Id);

            return produtos;
        }

        private void CarregaMarcas(Marca marca = null)
        {
            ViewBag.Marcas = new SelectList(ContextHelper.Contexto.Marca.ToList(), "Id", "Nome", marca);
        }

        private void CarregaModelo(Marca marca = null, Modelo modelo = null)
        {
            var result = ContextHelper.Contexto
                .Modelo.Where(m => m.Marca.Id == marca.Id);

            if (result.Count() > 0)
                ViewBag.Modelos = new SelectList(result, "Id", "Nome", modelo);
            else
                ViewBag.Modelos = new SelectList(new Modelo[] { });
        }

    }
}
