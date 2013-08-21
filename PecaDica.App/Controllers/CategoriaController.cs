using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.CategoriaServicos;
using PecaDica.App.Common;

namespace PecaDica.App.Controllers
{
    [Authorize(Roles = "loja")]
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/
        public int TamanhoDaPagina = 20;
        public ActionResult Index(int pagina = 1)
        {
            var categorias = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.AsEnumerable());
            
            ListaItemViewModel<Categoria>
                viewModel = new ListaItemViewModel<Categoria>()
                {
                    Items = categorias,
                    InformacaoDePaginacao = new InformacaoDePaginacao()
                    {
                        ItensPorPagina = TamanhoDaPagina,
                        PaginaAtual = pagina,
                        TotalDeItems = categorias.Count(),
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
        public ActionResult Novo(Categoria item)
        {
            ContextHelper.CategoriaCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Categoria item = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Categoria item)
        {
            ContextHelper.CategoriaCliente.Alterar(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Categoria item = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Categoria item)
        {
            ContextHelper.CategoriaCliente.Deletar(item);
            return RedirectToAction("Index");
        }
    }
}
