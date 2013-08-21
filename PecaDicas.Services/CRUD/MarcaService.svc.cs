using System;
using System.Security.Permissions;
using System.ServiceModel;
using PecaDicas.Contratos.Common;
using PecaDicas.Services.Common;
using PecaDicas.Services.DataServices;
using System.Collections.Generic;
using System.Data;

namespace PecaDicas.Services
{    
    public class MarcaService : PecaDicas.Contratos.IMarcaService
    {
        [PrincipalPermission(SecurityAction.Demand, Role="loja")]
        public void Inserir(Marca item)            
        {
            try
            {
                PersistenciaHelper.Instance.AddToMarca(item);
                PersistenciaHelper.Instance.SaveChanges();
            }            
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao inserir Marca",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Marca item)            
        {
            try
            {           
                PersistenciaHelper.Instance.Marca.DeleteObject(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao deletar Marca",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Marca item)            
        {
            try
            {                               
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao alterar Marca",
                    MensagemInterna = ex.Message,
                });
            }  
        }
    }
}
