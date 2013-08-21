using System;
using System.Security.Permissions;
using System.ServiceModel;
using System.Web.Security;
using PecaDicas.Contratos.Common;
using PecaDicas.Services.Common;
using PecaDicas.Services.DataServices;

namespace PecaDicas.Services
{
    public class LojaService : PecaDicas.Contratos.ILojaService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Inserir(Loja item)
        {
            try
            {
                Membership.CreateUser(item.NomeUsuario, item.Senha, item.Email);
                AtribuirRoleAUsuario(item.NomeUsuario);

                PersistenciaHelper.Instance.AddToLoja(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao inserir loja",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Deletar(Loja item)
        {
            try
            {
                Membership.DeleteUser(item.NomeUsuario);


                PersistenciaHelper.Instance.Loja.DeleteObject(item);
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao deletar loja",
                    MensagemInterna = ex.Message,
                });
            }
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Alterar(Loja item)
        {
            try
            {
                PersistenciaHelper.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new FaultException<DetalhamentoFalha>(new DetalhamentoFalha()
                {
                    Mensagem = "Falha ao alterar loja",
                    MensagemInterna = ex.Message,
                });
            }
        }

        private static void AtribuirRoleAUsuario(string NomeUsuario)
        {
            SqlRoleProvider roleProvider = new SqlRoleProvider();

            if (!roleProvider.RoleExists("loja"))
                roleProvider.CreateRole("loja");

            roleProvider.AddUsersToRoles(new string[] { NomeUsuario }, new string[] { "loja" });

        }
    }
}

