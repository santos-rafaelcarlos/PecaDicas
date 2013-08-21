﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PecaDica.App.Models;
using PecaDica.App.LojaServicos;
using PecaDica.App.Common;

namespace PecaDica.App.Controllers
{
    [Authorize(Roles="admin")]
    public class AdmController : Controller
    {
        public int TamanhoDaPagina = 20;
        //
        // GET: /Adm/
        [HttpGet]
        public ActionResult Index(int pagina = 1, ListaItemViewModel<Loja> viewModel = null)
        {
            IEnumerable<Loja> lojas = Carregalojas();

            viewModel.Items = lojas;
            viewModel.InformacaoDePaginacao = new InformacaoDePaginacao()
            {
                ItensPorPagina = TamanhoDaPagina,
                PaginaAtual = pagina,
                TotalDeItems = lojas.Count(),
            };

            return View(viewModel);
        }

        private IEnumerable<Loja> Carregalojas()
        {
            return ConverterHelper<PecaDicaServicos.Loja, Loja>
                .ConvertAParaB(ContextHelper.Contexto.Loja.AsEnumerable());
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Novo(Loja item, FormCollection form)
        {            
            ContextHelper.LojaCliente.Inserir(item);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Editar(Guid id)
        {
            Loja item = ConverterHelper<PecaDicaServicos.Loja, Loja>
                    .ConvertAParaB(ContextHelper.Contexto.Loja.Where(c => c.Id == id).FirstOrDefault());            
            return View(item);
        }

        [HttpPost]
        public ActionResult Editar(Loja item)
        {
            ContextHelper.LojaCliente.Alterar(item);
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(Guid id)
        {
            Loja item = ConverterHelper<PecaDicaServicos.Loja, Loja>
                   .ConvertAParaB(ContextHelper.Contexto.Loja.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Loja item = ConverterHelper<PecaDicaServicos.Loja, Loja>
                    .ConvertAParaB(ContextHelper.Contexto.Loja.Where(c => c.Id == id).FirstOrDefault());
            return View(item);
        }

        [HttpPost]
        public ActionResult Delete(Loja item)
        {
            ContextHelper.LojaCliente.Deletar(item);
            return RedirectToAction("Index");
        }
    }
}