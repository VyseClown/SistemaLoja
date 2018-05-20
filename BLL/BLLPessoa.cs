using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BLL
{
    public class BLLPessoa
    {
        public bool Salvar(Pessoa item)
        {
            try
            {
                DALPessoa DALobj = new DALPessoa();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                {
                    DALobj = null;
                    return false;
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
                DALPessoa DALobj = new DALPessoa();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                {
                    DALobj = null;
                    return false;
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
                DALPessoa DALobj = new DALPessoa();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                {
                    DALobj = null;
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Salvar(Funcionario item)
        {
            try
            {
                DALPessoa DALobj = new DALPessoa();
                if (DALobj.Salvar(item) == true)
                {
                    DALobj = null;
                    return true;
                }
                else
                {
                    DALobj = null;
                    return false;
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
            try
            {
                DALPessoa DALObj = new DALPessoa();
                
                if ((lista = DALObj.listarEstados()) != null)
                {
                    return lista;
                }
                else
                    return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }
        public List<City> listarCidades(int estadoID)
        {
            List<City> lista = new List<City>();
            try
            {
                DALPessoa DALObj = new DALPessoa();

                if ((lista = DALObj.listarCidades(estadoID)) != null)
                {
                    return lista;
                }
                else
                    return lista;
            }
            catch (Exception)
            {
                return lista;
            }
        }
        public int pegarIDCidade(string cidade)
        {
            try
            {
                DALPessoa DALObj = new DALPessoa();
                return DALObj.pegarIDCidade(cidade);
            }
            catch (Exception)
            {
                return 0;

            }
        }
        public bool AlterarPessoa(Pessoa pes)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                objDALPessoa.Alterar(pes);
                return true;
            }
            catch (Exception)
            {

                return false;
            }            
        }

        public bool AlterarCliente(Cliente cli)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                objDALPessoa.Alterar(cli);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AlterarFuncionario(Funcionario func)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                objDALPessoa.Alterar(func);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AlterarEndereco(Endereco end)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                objDALPessoa.Alterar(end);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public ClienteModel retornarPessoaCliente(string cpf)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                ClienteModel cli = objDALPessoa.retornarPessoaCliente(cpf);
                return cli;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public FuncionarioModel retornarPessoaFuncionario(string cpf)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                FuncionarioModel func = objDALPessoa.retornarPessoaFuncionario(cpf);
                return func;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public ClienteModel retornarPessoaCliente(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                ClienteModel cli = objDALPessoa.retornarPessoaCliente(id);
                return cli;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public FuncionarioModel retornarPessoaFuncionario(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                FuncionarioModel func = objDALPessoa.retornarPessoaFuncionario(id);
                return func;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Pessoa retornarPessoa(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                Pessoa pessoa = objDALPessoa.retornarPessoa(id);
                return pessoa;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Cliente retornarCliente(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                Cliente pessoa = objDALPessoa.retornarCliente(id);
                return pessoa;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Funcionario retornarFuncionario(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                Funcionario pessoa = objDALPessoa.retornarFuncionario(id);
                return pessoa;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public Endereco retornarEndereco(int id)
        {
            try
            {
                DALPessoa objDALPessoa = new DALPessoa();
                Endereco end = objDALPessoa.retornarEndereco(id);
                return end;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
