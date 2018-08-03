using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProduto
    {
        public bool Salvar(Produto item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Produto.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

        }
        public void Excluir(Produto item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Categoria item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Modelo item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Marcas item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Tamanhos item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Cor item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public Categoria SelecionarCategoriaID(int id)
        {
            Categoria prod = new Categoria();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Categoria
                        where c.id == id
                        select c).FirstOrDefault();
            }
            return prod;
        }
        public Modelo SelecionarModeloID(int id)
        {
            Modelo prod = new Modelo();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Modelo
                        where c.id == id
                        select c).FirstOrDefault();
            }
            return prod;
        }
        public Marcas SelecionarMarcaID(int id)
        {
            Marcas prod = new Marcas();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Marcas
                        where c.id == id
                        select c).FirstOrDefault();
            }
            return prod;
        }
        public Tamanhos SelecionarTamanhoID(int id)
        {
            Tamanhos prod = new Tamanhos();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Tamanhos
                        where c.id == id
                        select c).FirstOrDefault();
            }
            return prod;
        }
        public Cor SelecionarCorID(int id)
        {
            Cor prod = new Cor();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Cor
                        where c.id == id
                        select c).FirstOrDefault();
            }
            return prod;
        }
        public void DiminuirEstoque(Produto produto)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                if (produto.quantidade > 0){
                    produto.quantidade--;
                    db.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                    //db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                else
                {
                    Produto prod = new Produto();
                    if ((prod = DALProduto.selecionarProdutoMMTC2(produto.marca.Value, produto.modelo.Value, produto.tamanho.Value, produto.categoriaid.Value, produto.preco.Value, produto.cor.Value)) != null)
                    {
                        prod.quantidade--;
                        db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                }
        }
        public void Alterar(Produto item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<Produto> Selecionar(Produto item)
        {
            List<Produto> Lista = new List<Produto>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                Lista = (from c in db.Produto
                         where c.descricao.Contains(item.descricao)
                         orderby c.descricao
                         select c).ToList();
            }
            return Lista;
        }
        public Produto SelecionarProdutoID(int id)
        {
            Produto prod = new Produto();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                prod = (from c in db.Produto
                         where c.id == id
                         orderby c.descricao
                         select c).FirstOrDefault();
            }
            return prod;
        }
        public List<Produto> retornaListaFiltroProduto(string cmd)
        {
            string conexao = "Server=DESKTOP-FIMICD4;Database=dbLojaQuiteriaModas;Trusted_Connection=True;";//SPLTF78 ou  FIMICD4 //"metadata=res://*/dbLojaModel.csdl|res://*/dbLojaModel.ssdl|res://*/dbLojaModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-SPLTF78;initial catalog=dbLojaQuiteriaModas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            List<Produto> lista = new List<Produto>();
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                SqlCommand command = new SqlCommand(cmd, connection);
                try
                {
                    connection.Open();
                    //lista = command.ExecuteNonQuery();
                    //return lista;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto prod = new Produto();
                            prod.id = (int)(reader["id"]);
                            prod.categoriaid = (int)(reader["categoriaid"]);
                            prod.preco = (decimal)(reader["preco"]);
                            prod.marca = (int)(reader["marca"]);
                            prod.modelo = (int)(reader["modelo"]);
                            prod.tamanho = (int)(reader["tamanho"]);
                            prod.cor = (int)(reader["cor"]);
                            prod.quantidade = (int)(reader["quantidade"]);
                            prod.codigodebarra = reader["codigodebarra"].ToString();
                            lista.Add(prod);

                            //agora fazer tudo só que no produto model
                            //reader["FirstName"].ToString();
                            //Convert.ToInt32(reader["Age"]);
                        }
                    }
                    connection.Close();
                    return lista;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        public static ProdutoModel SelecionarUm(string codigodebarra)
        {
            var obj = new ProdutoModel();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.codigodebarra == codigodebarra
                       join m in db.Marcas on p.marca equals m.id
                       join mod in db.Modelo on p.modelo equals mod.id
                       join cat in db.Categoria on p.categoriaid equals cat.id
                       join tam in db.Tamanhos on p.tamanho equals tam.id
                       join c in db.Cor on p.cor equals c.id
                       //orderby c.tamanho
                       select new ProdutoModel() {
                           categoria = cat.descricao,
                           condicional = p.condicional,
                           //descricao = p.descricao,
                           data = p.data.Value,
                           id = p.id,
                           marca = m.nome,
                           modelo = mod.nome,
                           preco = p.preco.Value,
                           tamanho = tam.nome,
                           codigodebarra = p.codigodebarra,
                           cor = c.Nome,
                       }).FirstOrDefault();

            }
            return obj;
        }
        public static List<ProdutoModel> SelecionarLista(string codigodebarra)
        {
            List<ProdutoModel> obj = new List<ProdutoModel>();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.codigodebarra == codigodebarra
                       join m in db.Marcas on p.marca equals m.id
                       join mod in db.Modelo on p.modelo equals mod.id
                       join cat in db.Categoria on p.categoriaid equals cat.id
                       join tam in db.Tamanhos on p.tamanho equals tam.id
                       join c in db.Cor on p.cor equals c.id
                       //orderby c.tamanho
                       select new ProdutoModel()
                       {
                           categoria = cat.descricao,
                           condicional = p.condicional,
                           //descricao = p.descricao,
                           data = p.data.Value,
                           id = p.id,
                           marca = m.nome,
                           modelo = mod.nome,
                           preco = p.preco.Value,
                           tamanho = tam.nome,
                           codigodebarra = p.codigodebarra,
                           cor = c.Nome,
                           quantidade = p.quantidade.Value,
                       }).ToList();

            }
            return obj;
        }
        public List<Modelo> SelecionarModeloLista()
        {
            List<Modelo> mode;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                mode = (from mod in db.Modelo
                        orderby mod.nome
                        select mod).ToList();
            }
            return mode;
        }
        public List<Marcas> SelecionarMarcaLista()
        {
            List<Marcas> mar;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                mar = (from m in db.Marcas
                       orderby m.nome
                       select m).ToList();
            }
            return mar;
        }

        public List<Cor> SelecionarCorLista()
        {
            List<Cor> t;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                t = (from cor in db.Cor
                     orderby cor.Nome
                     select cor).ToList();
            }
            return t;
        }

        public List<Tamanhos> SelecionarTamanhoLista()
        {
            List<Tamanhos> t;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                t = (from tam in db.Tamanhos
                     orderby tam.nome
                     select tam).ToList();
            }
            return t;
        }
        public static Produto selecionarProduto(string codigodebarra)
        {
            var obj = new Produto();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.codigodebarra == codigodebarra
                       //orderby c.tamanho
                       select p).FirstOrDefault();

            }
            return obj;
        }
        public static Produto selecionarProdutoMMTC(int m, int mod, int tam, int cat, decimal preco, int cor,string codigodebarra)
        {
            var obj = new Produto();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.marca == m && p.modelo == mod && p.tamanho == tam && p.categoriaid == cat && p.preco == preco && p.cor == cor && p.codigodebarra == codigodebarra
                       //orderby c.tamanho
                       select p).FirstOrDefault();

            }
            return obj;
        }
        public static List<Produto> selecionarProdutoMMTCLista(int m, int mod, int tam, int cat, decimal preco, int cor, string codigodebarra)
        {
            var obj = new List<Produto>();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.marca == m && p.modelo == mod && p.tamanho == tam && p.categoriaid == cat && p.cor == cor && p.codigodebarra == codigodebarra
                       //orderby c.tamanho
                       select p).ToList();

            }
            return obj;
        }
        public static Produto selecionarProdutoMMTC2(int m, int mod, int tam, int cat, decimal preco, int cor)
        {
            var obj = new Produto();
            //var itemE = new estoque();
            //itemE = item;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Produto
                       where p.marca == m && p.modelo == mod && p.tamanho == tam && p.categoriaid == cat && p.preco == preco && p.cor == cor && p.quantidade > 0
                       //orderby c.tamanho
                       select p).FirstOrDefault();

            }
            return obj;
        }
        public string SelecionarModeloComCodigo(int id)
        {
            string nome;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                nome = (from mod in db.Modelo
                       where mod.id == id
                       select mod.nome).FirstOrDefault();
            }
            return nome;
        }
        public string SelecionarMarcaComCodigo(int id)
        {
            string nome;
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                nome = (from m in db.Marcas
                        where m.id == id
                        select m.nome).FirstOrDefault();
            }
            return nome;
        }
        public string SelecionarTamanhoComCodigo(int id)
        {
            string nome;
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                nome = (from tam in db.Tamanhos
                        where tam.id == id
                        select tam.nome).FirstOrDefault();
            }
            return nome;
        }
        public int SelecionarModeloIDComNome(string nome)
        {
            int id;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                id = (from mod in db.Modelo
                      where mod.nome.Contains(nome)
                      select mod.id).FirstOrDefault();
            }
            return id;
        }
        public int SelecionarMarcaIDComNome(string nome)
        {
            int id;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                id = (from m in db.Marcas
                      where m.nome.Contains(nome)
                      select m.id).FirstOrDefault(); 
            }
            return id;
        }
        public int SelecionarTamanhoIDComNome(string nome)
        {
            int id;
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                id = (from tam in db.Tamanhos
                      where tam.nome.Contains(nome)
                      select tam.id).FirstOrDefault();
            }
            return id;
        }
        public void Salvar(Marcas item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Marcas.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        public void Salvar(Cor item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Cor.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        public void Salvar(Modelo item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Modelo.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        public void Salvar(Tamanhos item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {

                    //db.categoria.Attach(item);
                    db.Tamanhos.Add(item);
                    //db.Entry(item).State = System.Data.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
    }
}
