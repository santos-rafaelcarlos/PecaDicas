using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.ProdutoServicos;
using PecaDica.App.Models;
using PecaDica.App.Common;

namespace PecaDica.App.Controllers
{
    [Authorize(Roles="loja")]
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/
        private Loja Loja = null;

        public ProdutoController()
        {
            string userName = System.Web.Security.Membership.GetUser().UserName;

            Loja = ConverterHelper<PecaDicaServicos.Loja, Loja>
                    .ConvertAParaB(ContextHelper.Contexto.Loja.Where(c =>string.Compare(c.NomeUsuario,userName,true) == 0)
                    .FirstOrDefault());
            
        }

        public int TamanhoDaPagina = 20;
        public ActionResult Index(int pagina = 1)
        {
            var produtos = ConverterHelper<PecaDicaServicos.Produto, Produto>
                    .ConvertAParaB(ContextHelper.Contexto.Produto
                    .Where(c => c.Loja.Id == Loja.Id));
            

            ListaItemViewModel<Produto>
               viewModel = new ListaItemViewModel<Produto>()
               {
                   Items =produtos,
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
        public ActionResult Novo(Produto item,FormCollection form)
        {
            Guid categoriaID = Guid.Empty;
            Guid modeloID = Guid.Empty;

            if (Guid.TryParse(form["Categorias"], out categoriaID))
                item.Categoria = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == categoriaID).FirstOrDefault());
            
            if (Guid.TryParse(form["Modelos"], out modeloID))
                item.Modelo = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == modeloID).FirstOrDefault());
            
            item.Loja =Loja;

            ContextHelper.ProdutoCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Produto item = ConverterHelper<PecaDicaServicos.Produto, Produto>
                    .ConvertAParaB(ContextHelper.Contexto.Produto.Where(c => c.Id == id).FirstOrDefault());
            
            CarregaModelo(item.Modelo);
            CarregaCategoria(item.Categoria);

            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Produto item, FormCollection form)
        {
            Guid categoriaID = Guid.Empty;
            Guid modeloID = Guid.Empty;

            if (Guid.TryParse(form["Categorias"], out categoriaID))
                item.Categoria = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.Where(c => c.Id == categoriaID).FirstOrDefault());

            if (Guid.TryParse(form["Modelos"], out modeloID))
                item.Modelo = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.Where(c => c.Id == modeloID).FirstOrDefault());

            ContextHelper.ProdutoCliente.Alterar(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Produto item = ConverterHelper<PecaDicaServicos.Produto, Produto>
                    .ConvertAParaB(ContextHelper.Contexto.Produto.Where(c => c.Id == id).FirstOrDefault());
            
            return View(item);
        }

        [HttpPost]        
        public ActionResult Delete(Produto item)
        {
            ContextHelper.ProdutoCliente.Deletar(item);
            return RedirectToAction("Index");
        }

        private void CarregaModelo(Modelo modelo = null)
        {
            var modelos = ConverterHelper<PecaDicaServicos.Modelo, Modelo>
                    .ConvertAParaB(ContextHelper.Contexto.Modelo.AsEnumerable());

            ViewBag.Modelos = new SelectList(modelos, "Id", "Nome", modelo);
        }

        private void CarregaCategoria(Categoria categoria = null)
        {
            var categorias = ConverterHelper<PecaDicaServicos.Categoria, Categoria>
                    .ConvertAParaB(ContextHelper.Contexto.Categoria.AsEnumerable());

            ViewBag.Categorias = new SelectList(categorias,"Id","Nome", categoria);
        }
    }
}
