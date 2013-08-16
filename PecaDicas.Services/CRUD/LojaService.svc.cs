using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PecaDicas.Contratos;
using PecaDicas.Contratos.Common;
using System.Security.Permissions;
using System.Web.Security;

namespace PecaDicas.Services
{ 
    public class LojaService : ILojaService
    {
        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Inserir(Loja item)
        {
            Membership.CreateUser(item.NomeUsuario, item.Senha, item.Email);

            AtribuirRoleAUsuario(item.NomeUsuario);

            ///Inserir dados no banco
            
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Deletar(Loja item)
        {
            Membership.DeleteUser(item.NomeUsuario);

            ///deletar dados no banco
            throw new NotImplementedException();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Admin")]
        public void Alterar(Loja item)
        {
            throw new NotImplementedException();
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
