﻿using System;
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
        [PrincipalPermission(SecurityAction.Demand, Role="loja")]
        public void Inserir(Categoria item)            
        {
            try
            {

                if (item.Id == Guid.Empty)
                    item.Id = Guid.NewGuid();

                PersistenciaHelper.Instance.AddToCategoria(item);
                PersistenciaHelper.Instance.SaveChanges();
            }            
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao inserir categoria",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Deletar(Categoria item)            
        {
            try
            {           
                PersistenciaHelper.Instance.Categoria.DeleteObject(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao deletar categoria",
                    MensagemInterna = ex.Message,
                });
            }  
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "loja")]
        public void Alterar(Categoria item)            
        {
            try
            {                               
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao alterar categoria",
                    MensagemInterna = ex.Message,
                });
            }  
        }
    }
}
