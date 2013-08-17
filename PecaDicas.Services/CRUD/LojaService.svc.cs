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
        public void Inserir(PecaDicas.Contratos.Loja item)
        {
            try
            {
                Loja loja = new Loja()
                {
                    Id = item.ID,
                    Nome = item.Nome,
                    NomeUsuario = item.NomeUsuario,
                    Email = item.Email,
                    Endereco = item.Endereco,
                    Senha = item.Senha,
                };

                Membership.CreateUser(loja.NomeUsuario, loja.Senha, loja.Email);
                AtribuirRoleAUsuario(loja.NomeUsuario);

                PersistenciaHelper.Instance.AddToLoja(loja);
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

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Deletar(PecaDicas.Contratos.Loja item)
        {
            try
            {
                Loja loja = ConverterHelper<Loja>.TryConverter(PersistenciaHelper.GetItem("Loja", item.ID));

                Membership.DeleteUser(loja.NomeUsuario);


                PersistenciaHelper.Instance.Loja.DeleteObject(loja);
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

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Alterar(PecaDicas.Contratos.Loja item)
        {
            try
            {
                Loja loja = ConverterHelper<Loja>.TryConverter(PersistenciaHelper.GetItem("Loja", item.ID));
                loja.Nome = item.Nome;
                loja.NomeUsuario = item.NomeUsuario;
                loja.Senha = item.Senha;
                loja.Endereco = item.Endereco;
                loja.Email = item.Email;

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

        private static void AtribuirRoleAUsuario(string NomeUsuario)
        {
            SqlRoleProvider roleProvider = new SqlRoleProvider();

            if (!roleProvider.RoleExists("loja"))
                roleProvider.CreateRole("loja");

            roleProvider.AddUsersToRoles(new string[] { NomeUsuario }, new string[] { "loja" });

        }
    }
}

