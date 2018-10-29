using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace DAL
{
    public class DALLogin
    {
        public List<UsuarioPermissoes> logarNoSistema(string login, string senha)
        {

            List<UsuarioPermissoes> per = new List<UsuarioPermissoes>();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                per = (from up in db.UsuarioPermissoes
                       join p in db.Permissoes on up.idPermissao equals p.id
                       join usu in db.Usuario on up.idUsuario equals usu.id
                       where usu.login == login && usu.senha == senha
                       select up).ToList();
                return per;
            }

        }
    }
}
