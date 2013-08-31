using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.DataServ;
using PecaDica.App.Common;

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
            ListaItemViewModel<ProdutoModel>
                viewModel = new ListaItemViewModel<ProdutoModel>();

            CarregaMarcas(Session["Marca"] != null ? Session["Marca"].ToString() : null);
            if (Session["Marca"] != null)
                CarregaModelo(Session["Marca"].ToString(), Session["Modelo"] != null ? Session["Modelo"].ToString() : null);
            else
                ViewBag.Modelos = new SelectList(new Modelo[] { });

            IEnumerable<Produto> produtos = CarregaProduto(Session["Modelo"] != null ? Session["Modelo"].ToString() : null);

            viewModel.Items = ConverterHelper<DataServ.Produto, ProdutoModel>.ConvertAParaB(produtos);

            viewModel.InformacaoDePaginacao = new InformacaoDePaginacao()
            {
                ItensPorPagina = TamanhoDaPagina,
                PaginaAtual = pagina,
                TotalDeItems = produtos.Count(),
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(ListaItemViewModel<ProdutoModel> viewModel, FormCollection form)
        {
            Guid marcaId;
            Guid modeloId;

            if (Guid.TryParse(form["Marcas"], out marcaId))
                Session["Marca"] = marcaId;

            if (Guid.TryParse(form["Modelos"], out modeloId))
                Session["Modelo"] = modeloId;

            return RedirectToAction("Index", viewModel);
        }

        private IEnumerable<Produto> CarregaProduto(string modeloId = null)
        {
            IEnumerable<Produto> produtos = new Produto[] { };

            if (modeloId != null)
                produtos = ContextHelper.Contexto.Produto.Where(c => c.ModeloID == Guid.Parse(modeloId));

            return produtos;
        }

        private void CarregaMarcas(string marcaId = null)
        {
            var marcas = new Marca[] { };
            try
            {
                marcas = ContextHelper.Contexto.Marca.ToArray();
            }
            catch
            {
                marcas = new Marca[] { };
            }

            ViewBag.Marcas = new SelectList(marcas, "Id", "Nome", marcaId == null ? null :
                ContextHelper.Contexto.Marca.Where(m => m.Id == Guid.Parse(marcaId)).FirstOrDefault());
        }

        private void CarregaModelo(string marcaId = null, string modeloId = null)
        {
            IEnumerable<Modelo> modelos = new Modelo[] { };

            if (marcaId != null)
                modelos = ContextHelper.Contexto.Modelo.Where(c => c.MarcaID== Guid.Parse(marcaId));

            ViewBag.Modelos = new SelectList(modelos, "Id", "Nome", modeloId == null ? null :
                ContextHelper.Contexto.Modelo.Where(m => m.Id == Guid.Parse(modeloId)).FirstOrDefault());
        }

    }
}
