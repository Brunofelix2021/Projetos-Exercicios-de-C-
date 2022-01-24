using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace ERP_Senac
{
    class Cliente
    {
        public int intCodigo { get; set; }
        public string strCPF { get; set; }
        public string strNome { get; set; }
        public string strEndereco { get; set; }
        public string strNumero { get; set; }
        public string strComplemento { get; set; }
        public string strBairro { get; set; }
        public string strCEP { get; set; }
        public string strCidade { get; set; }
        public string strEstado { get; set; }
        public List<string> Telefones = new List<string>();

        public Cliente()
        {
            intCodigo = 0;
            strCPF = string.Empty;
            strNome = string.Empty;
            strEndereco = string.Empty;
            strNumero = string.Empty;
            strComplemento = string.Empty;
            strBairro = string.Empty;
            strCEP = string.Empty;
            strCidade = string.Empty;
            strEstado = string.Empty;
            Telefones.Clear();
        }
        AcessoBD oAcessoBD = new AcessoBD();
        DataTable dtCliente = new DataTable();
        List<SqlParameter> oParametros = new List<SqlParameter>();
        string strSql = string.Empty;

        public void Consultar()
        {
            try
            {
                oParametros.Clear();
                strSql = "SELECT CLI_CODIGO, CLI_NOME, \n";
                strSql += "CLI_ENDERECO, CLI_NUMERO, \n";
                strSql += "CLI_COMPLEMENTO, CLI_BAIRRO, CLI_CEP, \n";
                strSql += "CLI_CIDADE, CLI_ESTADO \n";
                strSql += "FROM TB_CLIENTE_CLI \n";
                strSql += "WHERE CLI_CPF = @p_CPF";
                oParametros.Add(new SqlParameter("@p_CPF", strCPF));

                dtCliente = oAcessoBD.ConsultarSQL(strSql, oParametros);

                if (dtCliente.Rows.Count == 1)
                {
                    intCodigo = Convert.ToInt32(dtCliente.Rows[0]["CLI_CODIGO"]);
                    strNome = dtCliente.Rows[0]["CLI_NOME"].ToString();
                    strEndereco = dtCliente.Rows[0]["CLI_ENDERECO"].ToString();
                    strNumero = dtCliente.Rows[0]["CLI_NUMERO"].ToString();
                    strComplemento = dtCliente.Rows[0]["CLI_COMPLEMENTO"].ToString();
                    strCEP = dtCliente.Rows[0]["CLI_CEP"].ToString();
                    strBairro = dtCliente.Rows[0]["CLI_BAIRRO"].ToString();
                    strCidade = dtCliente.Rows[0]["CLI_CIDADE"].ToString();
                    strEstado = dtCliente.Rows[0]["CLI_ESTADO"].ToString();

                    oParametros.Clear();
                    strSql = "SELECT TEL_NUMERO FROM TB_TELEFONE_TEL \n";
                    strSql += "WHERE CLI_CODIGO = @p_CodigoCliente";
                    oParametros.Add(new SqlParameter("@p_CodigoCliente", intCodigo));
                    dtCliente = oAcessoBD.ConsultarSQL(strSql, oParametros);
                    Telefones.Clear();
                    foreach (DataRow linha in dtCliente.Rows)
                    {
                        Telefones.Add(linha["TEL_NUMERO"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Gravar()
        {
            try
            {
                using (TransactionScope transacao = new TransactionScope())
                {
                    oParametros.Clear();
                    if (intCodigo == 0)
                    {
                        strSql = "INSERT INTO TB_CLIENTE_CLI \n";
                        strSql += "(CLI_CPF, CLI_NOME, CLI_ENDERECO, CLI_NUMERO, CLI_COMPLEMENTO, \n";
                        strSql += "CLI_CEP, CLI_BAIRRO, CLI_CIDADE, CLI_ESTADO)\n";
                        strSql += "VALUES \n";
                        strSql += "(@p_CPF, @p_Nome, @p_Endereco, @p_Numero, @p_Complemento, \n";
                        strSql += "@p_CEP, @p_Bairro, @p_Cidade, @p_Estado);";
                        strSql += "SELECT @@IDENTITY";
                    }
                    else
                    {
                        strSql = "UPDATE TB_CLIENTE_CLI SET \n";
                        strSql += "CLI_CPF = @p_CPF, \n";
                        strSql += "CLI_NOME = @p_Nome, \n";
                        strSql += "CLI_ENDERECO = @p_Endereco, \n";
                        strSql += "CLI_NUMERO = @p_Numero, \n";
                        strSql += "CLI_COMPLEMENTO = @p_Complemento, \n";
                        strSql += "CLI_CEP = @p_CEP, \n";
                        strSql += "CLI_BAIRRO = @p_Bairro, \n";
                        strSql += "CLI_CIDADE = @p_Cidade, \n";
                        strSql += "CLI_ESTADO = @p_Estado \n";
                        strSql += "WHERE CLI_CODIGO = @p_Codigo";
                        oParametros.Add(new SqlParameter("@p_Codigo", intCodigo));
                    }
                    oParametros.Add(new SqlParameter("@p_CPF", strCPF));
                    oParametros.Add(new SqlParameter("@p_Nome", strNome));
                    oParametros.Add(new SqlParameter("@p_Endereco", strEndereco));
                    oParametros.Add(new SqlParameter("@p_Numero", strNumero));
                    oParametros.Add(new SqlParameter("@p_Complemento", strComplemento));
                    oParametros.Add(new SqlParameter("@p_CEP", strCEP));
                    oParametros.Add(new SqlParameter("@p_Bairro", strBairro));
                    oParametros.Add(new SqlParameter("@p_Cidade", strCidade));
                    oParametros.Add(new SqlParameter("@p_Estado", strEstado));

                    if (intCodigo == 0)
                    {
                        intCodigo = oAcessoBD.ExecutarSQL(strSql, oParametros);
                    }
                    else
                    {
                        oAcessoBD.ExecutarSQL(strSql, oParametros);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
