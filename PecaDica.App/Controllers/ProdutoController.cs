using System;
using System.Linq;
using System.Web.Mvc;
using PecaDica.App.Common;
using PecaDica.App.Models;
using PecaDica.App.ProdutoServ;
using PecaDica.App.LojaServ;

namespace PecaDica.App.Controllers
{
    [Authorize(Roles="loja")]
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/
        private Guid LojaID = Guid.Empty;

        public ProdutoController()
        {
            string userName = System.Web.Security.Membership.GetUser().UserName;

            LojaID = ContextHelper.Contexto.Loja
                .Where(c => System.String.Compare(c.NomeUsuario, userName, System.StringComparison.OrdinalIgnoreCase) == 0).FirstOrDefault().Id;
            
        }

        public int TamanhoDaPagina = 20;
        public ActionResult Index(int pagina = 1)
        {
            var produtos = ConverterHelper<DataServ.Produto, ProdutoModel>
                    .ConvertAParaB(ContextHelper.Contexto.Produto
                    .Where(c => c.LojaID == LojaID));


            ListaItemViewModel<ProdutoModel>
               viewModel = new ListaItemViewModel<ProdutoModel>()
               {
                   Items = produtos,
                   InformacaoDePaginacao = new InformacaoDePaginacao()
                   {
                       ItensPorPagina = TamanhoDaPagina,
                       PaginaAtual = pagina,
                       TotalDeItems = produtos.Count(),
                   },
               };

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Novo()
        {
            CarregaModelo();
            CarregaCategoria();

            return View();
        }


        [HttpPost]
        public ActionResult Novo(ProdutoModel item,FormCollection form)
        {
            Guid categoriaId;
            Guid modeloId;

            if (Guid.TryParse(form["Categorias"], out categoriaId))
                item.CategoriaID = categoriaId;

            if (Guid.TryParse(form["Modelos"], out modeloId))
                item.ModeloID = modeloId;

            item.LojaID = LojaID;

            ContextHelper.InsertProduto(ConverterHelper<ProdutoModel, Produto>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Produto item = ConverterHelper<DataServ.Produto, Produto>
                    .ConvertAParaB(ContextHelper.Contexto.Produto.Where(c => c.Id == id).FirstOrDefault());

            CarregaModelo(item.ModeloID != null ? item.ModeloID.ToString() : null);
            CarregaCategoria(item.CategoriaID != null ? item.CategoriaID.ToString() : null);

            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(ProdutoModel item, FormCollection form)
        {
            Guid categoriaId;
            Guid modeloId;

            if (Guid.TryParse(form["Categorias"], out categoriaId))
                item.CategoriaID = categoriaId;

            if (Guid.TryParse(form["Modelos"], out modeloId))
                item.ModeloID = modeloId;

            ContextHelper.AlterarProduto(ConverterHelper<ProdutoModel, Produto>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Produto item = ConverterHelper<DataServ.Produto, Produto>
                    .ConvertAParaB(ContextHelper.Contexto.Produto.Where(c => c.Id == id).FirstOrDefault());
            
            return View(item);
        }

        [HttpPost]        
        public ActionResult Delete(ProdutoModel item)
        {
            ContextHelper.DeletarProduto(ConverterHelper<ProdutoModel, Produto>.ConvertAParaB(item));
            return RedirectToAction("Index");
        }

        private void CarregaModelo(string modeloId = null)
        {
            var modelos = ContextHelper.Contexto.Modelo.AsEnumerable();

            ViewBag.Modelos = new SelectList(modelos, "Id", "Nome", modeloId == null ? null :
                ContextHelper.Contexto.Modelo.Where(m => m.Id == Guid.Parse(modeloId)).FirstOrDefault());
        }

        private void CarregaCategoria(string categoriaId = null)
        {
            var categorias =ContextHelper.Contexto.Categoria.AsEnumerable();

            ViewBag.Categorias = new SelectList(categorias, "Id", "Nome", categoriaId == null ? null :
                ContextHelper.Contexto.Categoria.Where(m => m.Id == Guid.Parse(categoriaId)).FirstOrDefault());
        }
    }
}
