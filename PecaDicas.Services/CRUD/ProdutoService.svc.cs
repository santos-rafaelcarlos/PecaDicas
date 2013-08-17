using System;
using System.Security.Permissions;
using System.ServiceModel;
using PecaDicas.Contratos.Common;
using PecaDicas.Services.Common;
using PecaDicas.Services.DataServices;

namespace PecaDicas.Services
{    
    public class ProdutoService : PecaDicas.Contratos.IProdutoService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Inserir(PecaDicas.Contratos.Produto item)
        {
            try
            {
                Produto produto = new Produto()
                {
                    Id = item.ID,                    
                    Nome = item.Nome,
                    Loja =  ConverterHelper<Loja>.TryConverter(PersistenciaHelper.GetItem("Loja",item.LojaID)),
                    Modelo = ConverterHelper<Modelo>.TryConverter(PersistenciaHelper.GetItem("Modelo", item.ModeloID)),
                    Categoria = ConverterHelper<Categoria>.TryConverter(PersistenciaHelper.GetItem("Categoria", item.CategoriaID)),                                        
                };

                PersistenciaHelper.Instance.AddToProduto(produto);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (ConverterException cEx)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = cEx.Message,
                });
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(PecaDicas.Contratos.Produto item)
        {
            try
            {
                Produto produto = ConverterHelper<Produto>.TryConverter(PersistenciaHelper.GetItem("Produto", item.ID));

                PersistenciaHelper.Instance.Produto.DeleteObject(produto);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (ConverterException cEx)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = cEx.Message,
                });
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(PecaDicas.Contratos.Produto item)
        {
            try
            {
                Produto produto = ConverterHelper<Produto>.TryConverter(PersistenciaHelper.GetItem("Produto", item.ID));
                produto.Nome = item.Nome;
                produto.Loja = ConverterHelper<Loja>.TryConverter(PersistenciaHelper.GetItem("Loja", item.LojaID));
                produto.Modelo = ConverterHelper<Modelo>.TryConverter(PersistenciaHelper.GetItem("Modelo", item.ModeloID));
                produto.Categoria = ConverterHelper<Categoria>.TryConverter(PersistenciaHelper.GetItem("Categoria", item.CategoriaID));

                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (ConverterException cEx)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = cEx.Message,
                });
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha",
                    MensagemInterna = ex.Message,
                });
            }
        }
    }
}
