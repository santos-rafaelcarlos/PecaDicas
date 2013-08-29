using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.MarcaServicos;
using PecaDica.App.Models;
using PecaDica.App.Common;


namespace PecaDica.App.Controllers
{
    [Authorize(Roles = "loja")]
    public class MarcaController : Controller
    {
        //
        // GET: /Marca/  
        public int TamanhoDaPagina = 20;
        public ActionResult Index(int pagina = 1)
        {
            var marcas = ConverterHelper<PecaDicaServicos.Marca, Marca>
                     .ConvertAParaB(ContextHelper.Contexto.Marca.AsEnumerable());

            ListaItemViewModel<Marca>
                 viewModel = new ListaItemViewModel<Marca>()
                 {
                     Items = marcas,
                     InformacaoDePaginacao = new InformacaoDePaginacao()
                     {
                         ItensPorPagina = TamanhoDaPagina,
                         PaginaAtual = pagina,
                         TotalDeItems = marcas.Count(),
                     },
                 };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Marca item)
        {           
            ContextHelper.MarcaCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Marca item = ConverterHelper<PecaDicaServicos.Marca, Marca>
                     .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Marca item)
        {
            ContextHelper.MarcaCliente.Alterar(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Marca item = ConverterHelper<PecaDicaServicos.Marca, Marca>
                    .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Marca item)
        {
            ContextHelper.MarcaCliente.Deletar(item);
            return RedirectToAction("Index");
        }
    }
}
