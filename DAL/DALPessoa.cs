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
    public class DALPessoa
    {
        public bool Salvar(Pessoa item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Pessoa.Add(item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Salvar(Endereco item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Endereco.Add(item);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Salvar(Cliente item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Cliente.Add(item);
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
        public bool Salvar(Funcionario item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Funcionario.Add(item);
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

        public bool Alterar(Pessoa item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public bool Alterar(Cliente item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Alterar(Funcionario item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Alterar(Endereco item)
        {
            try
            {
                using (quiteriamodasEntities db = new quiteriamodasEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
        public List<State> listarEstados()
        {
            List<State> lista = new List<State>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                
                lista = (from e in db.State
                         orderby e.Name
                         select e).ToList();
                
            }
            return lista;
        }


        public List<City> listarCidades(int estadoID)
        {
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                List<City> lista = new List<City>();
                lista = (from e in db.City
                         where e.IdState == estadoID
                         orderby e.Name
                         select e).ToList();
                return lista;
            }
        }
        public int pegarIDCidade(string cidade)
        {
            int id = 0;
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                id = (from e in db.City
                      where e.Name.Contains(cidade)
                      select e.Id).FirstOrDefault();
            }
            return id;
        }
        public Pessoa retornarPessoa(int id)
        {
            Pessoa pes = new Pessoa();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa
                      where p.id == id
                      select p).FirstOrDefault();
            }
            return pes;
        }
        public Pessoa retornarPessoaComIDCliente(int id)
        {
            Pessoa pes = new Pessoa();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from cli in db.Cliente
                       where cli.id == id
                       join p in db.Pessoa on cli.idPessoa equals p.id
                       select p).FirstOrDefault();
            }
            return pes;
        }
        public Cliente retornarCliente(int id)
        {
            Cliente pes = new Cliente();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa
                       where p.id == id
                       join c in db.Cliente on p.id equals c.idPessoa
                       select c).FirstOrDefault();
            }
            return pes;
        }
        public Cliente retornarClienteComConta(int id)
        {
            Cliente pes = new Cliente();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa
                    join c in db.Cliente on p.id equals c.idPessoa
                   // join v in db.Venda on c.id equals v.idCliente
                    where p.id == id && c.totalComprado > 0
                    select c).FirstOrDefault();
            }
            return pes;
        }
        public List<Pessoa> ListarClienteComConta()
        {
            List<Pessoa> pes = new List<Pessoa>();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa
                    join c in db.Cliente on p.id equals c.idPessoa
                    // join v in db.Venda on c.id equals v.idCliente
                    where c.totalComprado > 0
                    select p).ToList();
            }
            return pes;
        }
        public Funcionario retornarFuncionario(int id)
        {
            Funcionario pes = new Funcionario();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa
                       where p.id == id
                       join f in db.Funcionario on p.id equals f.idPessoa
                       select f).FirstOrDefault();
            }
            return pes;
        }
        public Endereco retornarEndereco(int id)
        {
            Endereco end = new Endereco();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                end = (from p in db.Pessoa
                       where p.id == id
                       join e in db.Endereco on p.idEndereco equals e.id
                       select e).FirstOrDefault();
            }
            return end;
        }
        public bool retornarPessoaCPF(string cpf)
        {
            Pessoa pes = new Pessoa();
            using(quiteriamodasEntities db = new quiteriamodasEntities())
            {
                if ((pes = (from p in db.Pessoa where p.CPF == cpf select p).FirstOrDefault()) != null)
                    return true;
                else
                    return false;
            }
        }
        public Pessoa retornarPessoaCPFObjeto(string cpf)
        {
            Pessoa pes = new Pessoa();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                pes = (from p in db.Pessoa where p.CPF == cpf select p).FirstOrDefault();
                return pes;
            }
        }

        public ClienteModel retornarPessoaCliente(string cpf)
        {
            ClienteModel obj = new ClienteModel();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Pessoa
                       where p.CPF == cpf
                       join cli in db.Cliente on p.id equals cli.idPessoa
                       join e in db.Endereco on p.idEndereco equals e.id
                       join c in db.City on e.idCidade equals c.Id
                       join s in db.State on c.IdState equals s.Id
                       //orderby c.tamanho
                       select new ClienteModel()
                       {
                           nome = p.nome,
                           celular = p.celular,
                           celular2 = p.celular2,
                           CPF = p.CPF,
                           dataNascimento = p.datanascimento.Value,
                           dataUltimoPagamento = p.datanascimento.Value,
                           email = p.email,
                           id = p.id,
                           telefone = p.telefone,
                           telefone2 = p.telefone2,
                           limitecredito = cli.limitecredito.Value,
                           totalComprado = cli.totalComprado.Value,
                           bairro = e.bairro,
                           idCidade = c.Id,
                           idEndereco = e.id,
                           numero = e.numero,
                           rua = e.rua,
                           idEstado = s.Id,
                           RG = p.RG,
                           CEP = e.CEP,
                       }).FirstOrDefault();
            }
            return obj;
        }

        public Funcionario retornarUltimoFuncionario()
        {
            Funcionario func = new Funcionario();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                func = (from e in db.Funcionario orderby e.id descending select e).First();
                return func;
            }
        }

        public Cliente retornarUltimoCliente()
        {
            Cliente func = new Cliente();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                func = (from e in db.Cliente orderby e.id descending select e).First();
                return func;
            }
            
        }
        public Pessoa retornarUltimaPessoa()
        {
            Pessoa func = new Pessoa();

            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                func = (from e in db.Pessoa orderby e.id descending select e).First();
                return func;
            }

        }

        public FuncionarioModel retornarPessoaFuncionario(string cpf)
        {
            FuncionarioModel obj = new FuncionarioModel();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Pessoa
                       where p.CPF == cpf
                       join f in db.Funcionario on p.id equals f.idPessoa
                       join e in db.Endereco on p.idEndereco equals e.id
                       join c in db.City on e.idCidade equals c.Id
                       join s in db.State on c.IdState equals s.Id
                       //orderby c.tamanho
                       select new FuncionarioModel()
                       {
                           nome = p.nome,
                           celular = p.celular,
                           celular2 = p.celular2,
                           CPF = p.CPF,
                           dataNascimento = p.datanascimento.Value,
                           email = p.email,
                           id = p.id,
                           telefone = p.telefone,
                           telefone2 = p.telefone2,
                           idUsuario = 0,
                           salario = f.Salario.Value,
                           vendas = f.Vendas.Value,
                           bairro = e.bairro,
                           idCidade = e.idCidade.Value,
                           idEndereco = e.id,
                           numero = e.numero,
                           rua = e.rua,
                           idEstado = s.Id,
                           RG = p.RG,
                           CEP = e.CEP,
                       }).FirstOrDefault();
            }
            return obj;
        }
        public ClienteModel retornarPessoaCliente(int id)
        {
            ClienteModel obj = new ClienteModel();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Pessoa
                       where p.id == id
                       join cli in db.Cliente on p.id equals cli.idPessoa
                       join e in db.Endereco on p.idEndereco equals e.id
                       join c in db.City on e.idCidade equals c.Id
                       join s in db.State on c.IdState equals s.Id
                       //orderby c.tamanho
                       select new ClienteModel()
                       {
                           nome = p.nome,
                           celular = p.celular,
                           celular2 = p.celular2,
                           CPF = p.CPF,
                           dataNascimento = p.datanascimento.Value,
                           dataUltimoPagamento = p.datanascimento.Value,
                           email = p.email,
                           id = p.id,
                           telefone = p.telefone,
                           telefone2 = p.telefone2,
                           limitecredito = cli.limitecredito.Value,
                           totalComprado = cli.totalComprado.Value,
                           bairro = e.bairro,
                           idCidade = c.Id,
                           idEndereco = e.id,
                           numero = e.numero,
                           rua = e.rua,
                           idEstado = s.Id,
                           RG = p.RG,
                       }).FirstOrDefault();
            }
            return obj;
        }
        public FuncionarioModel retornarPessoaFuncionario(int id)
        {
            FuncionarioModel obj = new FuncionarioModel();
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                obj = (from p in db.Pessoa
                       where p.id == id
                       join f in db.Funcionario on p.id equals f.idPessoa
                       join e in db.Endereco on p.idEndereco equals e.id
                       join c in db.City on e.idCidade equals c.Id
                       join s in db.State on c.IdState equals s.Id
                       //orderby c.tamanho
                       select new FuncionarioModel()
                       {
                           nome = p.nome,
                           celular = p.celular,
                           celular2 = p.celular2,
                           CPF = p.CPF,
                           dataNascimento = p.datanascimento.Value,
                           email = p.email,
                           id = p.id,
                           telefone = p.telefone,
                           telefone2 = p.telefone2,
                           idUsuario = 0,
                           salario = f.Salario.Value,
                           vendas = f.Vendas.Value,
                           bairro = e.bairro,
                           idCidade = e.idCidade.Value,
                           idEndereco = e.id,
                           numero = e.numero,
                           rua = e.rua,
                           idEstado = s.Id,
                           RG = p.RG,
                       }).FirstOrDefault();
            }
            return obj;
        }
        public void Excluir(Pessoa item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Cliente item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void Excluir(Funcionario item)
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Pessoa> listarPessoas()
        {
            using (quiteriamodasEntities db = new quiteriamodasEntities())
            {
                List<Pessoa> lista = new List<Pessoa>();
                lista = (from e in db.Pessoa
                    
                    join c in db.Cliente on e.id equals c.idPessoa
                    orderby e.nome
                    select e).ToList();
                return lista;
            }
        }
    }
}
