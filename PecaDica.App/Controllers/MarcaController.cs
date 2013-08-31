using System;
using System.Linq;
using System.Web.Mvc;
using PecaDica.App.Common;
using PecaDica.App.MarcaServ;
using PecaDica.App.Models;


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
            var marcas = ConverterHelper<DataServ.Marca, Marca>
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
            ContextHelper.InsertMarca(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Marca item = ConverterHelper<DataServ.Marca, Marca>
                     .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Marca item)
        {
            ContextHelper.AlterarMarca(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Marca item = ConverterHelper<DataServ.Marca, Marca>
                    .ConvertAParaB(ContextHelper.Contexto.Marca.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Marca item)
        {
            ContextHelper.DeletarMarca(item);
            return RedirectToAction("Index");
        }
    }
}
