using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRM_Senac
{
    class AcessoBD
    {
        //Criamos uma variável static para receber a string de conexao existente no arquivo APP.CONFIG
        public static string strConexao;
        //Criamos um objeto de conexão SQL para acesso ao Banco de Dados
        SqlConnection oConn;

        //Criamos o método Conectar para abrir a conexão com o banco de dados
        private void Conectar()
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Instanciamos o objeto de conexão com a string de conexão existente no arquivo APP.CONFIG
                oConn = new SqlConnection(strConexao);
                //Abrimos o banco de dados
                oConn.Open();
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //E "jogamos" esse erro para o método na camada anterior no processamento
                throw new Exception(ex.Message);
            }
        }
        //Criamos o método Desconectar para fechar a conexão com o banco de dados
        private void Desconectar()
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Verificamos se o estado (State) da conexão está aberto (Open)
                if (oConn.State == ConnectionState.Open)
                {
                    //Fechamos a conexão
                    oConn.Close();
                    //Retiramos o objeto da memória
                    oConn.Dispose();
                }
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //E "jogamos" esse erro para o método na camada anterior no processamento
                throw new Exception(ex.Message);
            }
        }
        //Criamo o método Consultar para retornar o resultado de um SELECT em um DataTable
        //que recebe o comando SQL e uma lista de parâmetros SQL como parâmetros de entrada
        public DataTable Consultar(string pSql, List<SqlParameter> parametros)
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Chamamos o método Conectar para abrir a conexão com o banco de dados
                Conectar();
                //Instanciamos um objeto de comando SQL passando o SELECT e a conexão aberta como parâmetros
                SqlCommand oCmd = new SqlCommand(pSql, oConn);
                //Percorremos todos os parâmetros SQL existentes na lista de parâmetros
                foreach (SqlParameter p in parametros)
                {
                    //Adicionamos cada um dos parâmetros ao objeto de comando SQL
                    oCmd.Parameters.Add(p);
                }
                //Instanciamos um objeto Adaptador de Dados SQL passando o objeto de comando SQL como parâmetro
                SqlDataAdapter oAdp = new SqlDataAdapter(oCmd);
                //Instanciamos um objeto DataSet para ser populado com o retorno do SELECT
                DataSet ds = new DataSet();
                //Preeenchemos o DataSet com o resultado do SELECT, criando um DataTable com o nome de "Table"
                oAdp.Fill(ds, "Table");
                //Chamamos o método desconectar para fechar a conexão com o banco de dados
                Desconectar();
                //Retornamos o DataTable "Table" como resultado do método Consultar
                return ds.Tables["Table"];
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //E "jogamos" esse erro para o método na camada anterior no processamento
                throw new Exception(ex.Message);
            }
        }
        //Criamos o método Executar para efetuarmos INSERT, UPDATE e DELETE no banco de dados
        //passando como parâmetros de entrada a query (comando SQL) e sua lista de parâmetros
        //O método retorna um número inteiro, quando na query existir o SELECT @@IDENTITY
        public int Executar(string pSql, List<SqlParameter> parametros)
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Criamos uma variável que receberá o @@IDENTITY criado pelo banco de dados
                int intRetorno = 0;
                //Chamamos o método Conectar para abrir a conexão com o banco de dados
                Conectar();
                //Instanciamos um objeto de comando SQL passando o SELECT e a conexão aberta como parâmetros
                SqlCommand oCmd = new SqlCommand(pSql, oConn);
                //Percorremos todos os parâmetros SQL existentes na lista de parâmetros
                foreach (SqlParameter p in parametros)
                {
                    //Adicionamos cada um dos parâmetros ao objeto de comando SQL
                    oCmd.Parameters.Add(p);
                }
                //Executamos a query (comando SQL) e convertemos o seu retorno para inteiro
                //armazenando na variável de retorno intRetorno
                intRetorno = Convert.ToInt32(oCmd.ExecuteScalar());
                //Chamamos o método desconectar para fechar a conexão com o banco de dados
                Desconectar();
                //Retornamos o resultado da query convertido para inteiro
                return intRetorno;
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //E "jogamos" esse erro para o método na camada anterior no processamento
                throw new Exception(ex.Message);
            }
        }
    }
}
