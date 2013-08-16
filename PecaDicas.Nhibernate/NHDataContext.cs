using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using PecaDicas.Contratos;
using NHibernate;
using NHibernate.Engine;

namespace PecaDicas.Nhibernate
{
    public class NHDataContext : NHibernateDataContext
    {
        public NHDataContext(ISession session)
            : base(session)
        {
        }

        public IQueryable<Categoria> Categorias
        {
            get
            {                
                return new NhQueryable<Categoria>((ISessionImplementor)Session);
            }
        }

        public IQueryable<Produto> Produtos
        {
            get
            {
                return new NhQueryable<Produto>((ISessionImplementor)Session);
            }
        }

        public IQueryable<Loja> Lojas
        {
            get
            {

                return new NhQueryable<Loja>((ISessionImplementor)Session);

            }
        }

        public IQueryable<Marca> Marcas
        {
            get
            {
                return new NhQueryable<Marca>((ISessionImplementor)Session);
            }
        }

        public IQueryable<Modelo> Modelos
        {
            get
            {
                return new NhQueryable<Modelo>((ISessionImplementor)Session);
            }
        }
    }
}

