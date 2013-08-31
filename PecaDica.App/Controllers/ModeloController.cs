using System;
using System.Linq;
using System.Web.Mvc;
using PecaDica.App.Common;
using PecaDica.App.ModeloServ;
using PecaDica.App.Models;

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
            var modelos = ConverterHelper<DataServ.Modelo, ModeloModel>
                   .ConvertAParaB(ContextHelper.Contexto.Modelo.AsEnumerable());

            var viewModel = new ListaItemViewModel<ModeloModel>()
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

        private void CarregaMarca(string marcaId= null)
        {
            var marcas = ContextHelper.Contexto.Marca.AsEnumerable();

            ViewBag.Marcas = new SelectList(marcas, "Id", "Nome", marcaId == null ? null :
                ContextHelper.Contexto.Marca.Where(m => m.Id == Guid.Parse(marcaId)).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Novo(ModeloModel item,FormCollection form)
        {
            Guid marcaID = Guid.Empty;
            
            //todo: o que vem ñ é o guid
            if (Guid.TryParse(form["Marcas"], out marcaID))
                item.MarcaID = marcaID;

            ContextHelper.InsertModelo(ConverterHelper<ModeloModel, Modelo>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Modelo item = ConverterHelper<DataServ.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == id).FirstOrDefault());

            CarregaMarca(item.MarcaID != null ? item.MarcaID.ToString() : null);
            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(ModeloModel item, FormCollection form)
        {
            Guid marcaID = Guid.Empty;

            if (Guid.TryParse(form["Marcas"], out marcaID))
                item.MarcaID = marcaID;

            ContextHelper.AlterarModelo(ConverterHelper<ModeloModel, Modelo>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Modelo item = ConverterHelper<DataServ.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == id).FirstOrDefault());

            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(ModeloModel item)
        {
            ContextHelper.DeletarModelo(ConverterHelper<ModeloModel, Modelo>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }
    }
}
