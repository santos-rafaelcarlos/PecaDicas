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
    public class ModeloService : PecaDicas.Contratos.IModeloService
    {
        [PrincipalPermission(SecurityAction.Demand, Role="loja")]
        public void Inserir(Modelo item)            
        {
            try
            {
                PersistenciaHelper.Instance.AddToModelo(item);
                PersistenciaHelper.Instance.SaveChanges();
            }            
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao inserir Modelo",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Modelo item)            
        {
            try
            {           
                PersistenciaHelper.Instance.Modelo.DeleteObject(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao deletar modelo",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Modelo item)            
        {
            try
            {                               
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao alterar Modelo",
                    MensagemInterna = ex.Message,
                });
            }  
        }
    }
}
