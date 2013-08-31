using System;
using System.Linq;
using System.Web.Mvc;
using PecaDica.App.CatServ;
using PecaDica.App.Common;
using PecaDica.App.Models;

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
            var categorias = ConverterHelper<DataServ.Categoria, Categoria>
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
            ContextHelper.InsertCategoria(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Categoria item = ConverterHelper<DataServ.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Categoria item)
        {
            ContextHelper.AlterarCategoria(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Categoria item = ConverterHelper<DataServ.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Categoria item)
        {
            ContextHelper.DeletarCategoria(item);
            return RedirectToAction("Index");
        }
    }
}
