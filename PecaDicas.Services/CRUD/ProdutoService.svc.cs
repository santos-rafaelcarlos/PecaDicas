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
        public void Inserir(Produto item)
        {
            try
            {

                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();
                PersistenciaHelper.Instance.AddToProduto(item);                
                PersistenciaHelper.Instance.SaveChanges();
            }            
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao inserir produto",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Produto item)
        {
            try
            {
                PersistenciaHelper.Instance.Produto.DeleteObject(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao excluir produto.",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Produto item)
        {
            try
            {
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao alterar",
                    MensagemInterna = ex.Message,
                });
            }
        }
    }
}
