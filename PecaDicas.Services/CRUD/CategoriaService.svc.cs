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
    public class CategoriaService : PecaDicas.Contratos.ICategoriaService
    {
       // [PrincipalPermission(SecurityAction.Demand, Role="loja")]
        public void Inserir(PecaDicas.Contratos.Categoria item)            
        {
            try
            {
                Categoria categoria = new Categoria()
                {
                    Id = item.ID,
                    Descricao =item.Descricao,
                    Nome = item.Nome,
                };
                PersistenciaHelper.Instance.AddToCategoria(categoria);
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
        public void Deletar(PecaDicas.Contratos.Categoria item)            
        {
            try
            {
                Categoria categoria = ConverterHelper<Categoria>.TryConverter(PersistenciaHelper.GetItem("Categoria", item.ID));

                PersistenciaHelper.Instance.Categoria.DeleteObject(categoria);
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
        public void Alterar(PecaDicas.Contratos.Categoria item)            
        {
            try
            {
                Categoria categoria = ConverterHelper<Categoria>.TryConverter(PersistenciaHelper.GetItem("Categoria", item.ID));
                categoria.Nome = item.Nome;
                categoria.Descricao = item.Descricao;
                               
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
