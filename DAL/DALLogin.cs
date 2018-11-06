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
        public bool Salvar(Usuario usu, List<UsuarioPermissoes> per)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Usuario.Add(usu);
                    db.SaveChanges();
                    foreach (UsuarioPermissoes item in per)
                    {
                        item.idUsuario = usu.id;
                        db.UsuarioPermissoes.Add(item);
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Alterar(Usuario usu, List<UsuarioPermissoes> per)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(usu).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    List<UsuarioPermissoes> listaauxiliar = logarNoSistema(usu.login, usu.senha);
                    foreach (UsuarioPermissoes itemaux in listaauxiliar)
                    {
                        db.Entry(itemaux).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                    }

                    foreach (UsuarioPermissoes item in per)
                    {                       
                        db.UsuarioPermissoes.Add(item);
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool verificarExistencia(string login)
        {
            Usuario per = new Usuario();
            Usuario per2 = new Usuario();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                per = (from usu in db.Usuario
                       where usu.login == login
                       select usu).FirstOrDefault();
                if (per != null)
                    return true;
                else
                    return false;
            }
        }
        public Usuario retornarUsuario(string login)
        {
            Usuario per = new Usuario();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                per = (from usu in db.Usuario
                       where usu.login == login
                       select usu).FirstOrDefault();
                return per;
            }
        }
        public Usuario retornarUsuarioComPermissoes(string login)
        {
            Usuario per = new Usuario();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                per = (from usu in db.Usuario
                       where usu.login == login
                       select usu).FirstOrDefault();
                return per;
            }
        }
    }
}
