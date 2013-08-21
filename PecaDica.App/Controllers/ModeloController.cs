using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.ModeloServicos;
using PecaDica.App.Common;

namespace PecaDica.App.Controllers
{
    [Authorize(Roles = "loja")]
    public class ModeloController : Controller
    {
        //
        // GET: /Modelo/
        public int TamanhoDaPagina = 20;
        public ActionResult Index(int pagina = 1)
        {
            var modelos = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                   .ConvertAParaB(ContextHelper.Contexto.Modelo.AsEnumerable());
            
            ListaItemViewModel<Modelo>
                viewModel = new ListaItemViewModel<Modelo>()
                {
                    Items = modelos,
                    InformacaoDePaginacao = new InformacaoDePaginacao()
                    {
                        ItensPorPagina = TamanhoDaPagina,
                        PaginaAtual = pagina,
                        TotalDeItems = modelos.Count(),
                    },
                };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Novo()
        {
            CarregaMarca();
            return View();
        }

        private void CarregaMarca(Marca marca= null)
        {
            var marcas = ConverterHelper<PecaDicaServicos.Marca, Marca>
                   .ConvertAParaB(ContextHelper.Contexto.Marca.AsEnumerable());

            ViewBag.Marcas = new SelectList(marcas,"Id","Nome", marca);
        }

        [HttpPost]
        public ActionResult Novo(Modelo item,FormCollection form)
        {
            Guid marcaID = Guid.Empty;
            
            if (Guid.TryParse(form["Marcas"], out marcaID))
                item.Marca = ConverterHelper<PecaDicaServicos.Marca, Marca>
                    .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == marcaID).FirstOrDefault());

            ContextHelper.ModeloCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Modelo item = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == id).FirstOrDefault());

            CarregaMarca(item.Marca);
            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Modelo item, FormCollection form)
        {
            Guid marcaID = Guid.Empty;

            if (Guid.TryParse(form["Marcas"], out marcaID))
                item.Marca = ConverterHelper<PecaDicaServicos.Marca, Marca>
                    .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == marcaID).FirstOrDefault());

            ContextHelper.ModeloCliente.Alterar(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Modelo item = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Modelo item)
        {
            ContextHelper.ModeloCliente.Deletar(item);
            return RedirectToAction("Index");
        }
    }
}
