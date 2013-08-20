using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PecaDica.App.Models
{
    public class ListaItemViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }
        public InformacaoDePaginacao InformacaoDePaginacao { get; set; }
    }

    public class InformacaoDePaginacao
    {
        public int TotalDeItems { get; set; }
        public int ItensPorPagina { get; set; }
        public int PaginaAtual { get; set; }

        public int TotalDePaginas
        {
            get { return (int)Math.Ceiling((decimal)TotalDeItems / ItensPorPagina); }
        }
    }
}