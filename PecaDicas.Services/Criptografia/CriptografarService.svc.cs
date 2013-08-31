using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PecaDicas.Services.Common;
using PecaDicas.Contratos.Common;
using System.Security.Permissions;

namespace PecaDicas.Services
{    
    public class CriptografarService : PecaDicas.Contratos.ICriptografia
    {
        public string Criptografar(string text)
        {
            try
            {
                return CriptografiaHelper.Criptografar(text);
            }
            catch (ApplicationException aEx)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha() 
                {
                    Mensagem = aEx.Message,
                    MensagemInterna = aEx.InnerException == null ? string.Empty: aEx.InnerException.Message,
                });
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao Criptografar",
                    MensagemInterna = ex.Message,
                });
            }
        }
        
        public string Descriptografar(string text)
        {
            try
            {
                return CriptografiaHelper.Descriptografar(text);
            }
            catch (ApplicationException aEx)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = aEx.Message,
                    MensagemInterna = aEx.InnerException == null ? string.Empty : aEx.InnerException.Message,
                });
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao Descriptografar",
                    MensagemInterna = ex.Message,
                });
            }
        }
    }
}
