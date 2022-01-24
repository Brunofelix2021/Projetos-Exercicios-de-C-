using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CRM_Senac
{
    class Cliente
    {
        //Definimos oa atributos da classe Cliente, espelhando os dados que serão armazenados no banco de dados
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
        //Criamos uma lista para armazenar os telefones
        public List<string> strTelefones = new List<string>();
        //Criamos o método construtor para definirmos valores iniciais para os atributos
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
            strTelefones.Clear();
        }
        //Criamos um objeto da Classe AcessoBD para podermos utilizar seus métodos de acesso ao banco de dados
        AcessoBD oAcessoBD = new AcessoBD();
        //Criamos um objeto DataTable para armazenar os resultados dos SELECTs efetuados
        DataTable dtCliente = new DataTable();
        //Criamos uma variável string para armazenar os comandos SQL (queries)
        string strSql = string.Empty;
        //Criamos uma lista de parâmetros SQL para enviarmos as variáveis SQL para o banco de dados
        List<SqlParameter> oParametros = new List<SqlParameter>();
        //Criamos o método consultar para efetuarmos consultas no banco de dados
        public void Consultar()
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Iniciamos a query de consulta ao banco de dados trazendo todas as colunas dos clientes
                strSql = "select cli_codigo, cli_cpf, cli_nome, cli_endereco, cli_numero, \n";
                strSql += "cli_complemento, cli_bairro, cli_cep, cli_cidade, cli_estado \n";
                strSql += "from tb_cliente_cli \n";
                //passamos a condição de busca pelo CPF do cliente
                strSql += "where cli_cpf = @p_cpf";
                //Limpamos a lista de parâmetros SQL
                oParametros.Clear();
                //Adicionamos o CPF do cliente a lista de parâmetros SQL
                oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                //Executamos o método Consultar da Classe AcessoBD e armazenamos o retorno da consulta no DataTable dtCliente
                dtCliente = oAcessoBD.Consultar(strSql, oParametros);
                //Verificamos se a quantidade de registros retornados é 1
                if (dtCliente.Rows.Count == 1)
                {
                    //Caso exista um cliente com o CPF informado, atribuímos cada um dos valores retornados do banco de dados
                    //ao seu respectivo atributo na classe, efetuando as conversões de dados quando necessário
                    intCodigo = Convert.ToInt32(dtCliente.Rows[0]["cli_codigo"]);
                    strNome = dtCliente.Rows[0]["cli_nome"].ToString();
                    strEndereco = dtCliente.Rows[0]["cli_endereco"].ToString();
                    strNumero = dtCliente.Rows[0]["cli_numero"].ToString();
                    strComplemento = dtCliente.Rows[0]["cli_complemento"].ToString();
                    strBairro = dtCliente.Rows[0]["cli_bairro"].ToString();
                    strCEP = dtCliente.Rows[0]["cli_cep"].ToString();
                    strCidade = dtCliente.Rows[0]["cli_cidade"].ToString();
                    strEstado = dtCliente.Rows[0]["cli_estado"].ToString();
                    //Limpamos a lista de parâmetros SQL
                    oParametros.Clear();
                    //Montamos a query de consulta para obtermos os telefones do cliente consultado
                    strSql = "select tel_numero from tb_telefone_tel where cli_codigo = @p_codigo";
                    //Adicionamos o código do cliente (foreign key) a lista de parâmetros SQL
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                    //Executamos o método Consultar da Classe AcessoBD e armazenamos o retorno da consulta no DataTable dtCliente
                    dtCliente = oAcessoBD.Consultar(strSql, oParametros);
                    //Verificamos se existem registros retornados pela consulta
                    if (dtCliente.Rows.Count!=0)
                    {
                        //Limpamos a lista de telefones
                        strTelefones.Clear();
                        //Percorremos cada um dos registros do DataTable
                        foreach(DataRow linha in dtCliente.Rows)
                        {
                            //Adicionamos o telefone encontrado à lista de telefones
                            strTelefones.Add(linha["tel_numero"].ToString());
                        }
                    }
                }
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //E "jogamos" esse erro para o método na camada anterior no processamento
                throw new Exception(ex.Message);
            }
        }
        //Criamos o método gravar para efetuar as inclusões e alterações dos clientes no banco de dados
        public void Gravar()
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Iniciamos um TransactionScope (Escopo de Transação) para garantirmos a efetivação de todo
                //o processo de gravação no banco de dados (Cliente e Telefones)
                using (TransactionScope transacao = new TransactionScope())
                {
                    //Limpamos a lista de parâmetros SQL
                    oParametros.Clear();
                    //Verificamos se o cliente é um novo cliente (código = 0)
                    if (intCodigo == 0)
                    {
                        //Montamos a query de insert no banco de dados
                        strSql = "insert into tb_cliente_cli \n";
                        strSql += "(cli_cpf, cli_nome, cli_endereco, cli_numero, \n";
                        strSql += "cli_complemento, cli_bairro, cli_cep, cli_cidade, cli_estado)\n";
                        strSql += "values \n";
                        strSql += "(@p_cpf, @p_nome, @p_endereco, @p_numero, \n";
                        strSql += "@p_complemento, @p_bairro, @p_cep, @p_cidade, @p_estado);select @@identity;";
                    }
                    //ou um cliente já existente (codigo != 0)
                    else
                    {
                        //Montamos a query de update no banco de dados
                        strSql = "update tb_cliente_cli set \n";
                        strSql += "cli_cpf = @p_cpf,\n";
                        strSql += "cli_nome = @p_nome,\n";
                        strSql += "cli_endereco = @p_endereco,\n";
                        strSql += "cli_numero = @p_numero,\n";
                        strSql += "cli_complemento = @p_complemento,\n";
                        strSql += "cli_bairro = @p_bairro,\n";
                        strSql += "cli_cep = @p_cep,\n";
                        strSql += "cli_cidade = @p_cidade,\n";
                        strSql += "cli_estado = @p_estado\n";
                        strSql += "where cli_codigo = @p_codigo";
                        //Adicionamos o código do cliente separadamente a lista de parâmetros SQL, pois ele só 
                        //é citado na alteração do cliente
                        oParametros.Add(new SqlParameter("@p_Codigo", intCodigo));
                    }
                    //Adicionamos o restante dos parâmetros SQL
                    oParametros.Add(new SqlParameter("@p_cpf", strCPF));
                    oParametros.Add(new SqlParameter("@p_nome", strNome));
                    oParametros.Add(new SqlParameter("@p_endereco", strEndereco));
                    oParametros.Add(new SqlParameter("@p_numero", strNumero));
                    oParametros.Add(new SqlParameter("@p_complemento", strComplemento));
                    oParametros.Add(new SqlParameter("@p_bairro", strBairro));
                    oParametros.Add(new SqlParameter("@p_cep", strCEP));
                    oParametros.Add(new SqlParameter("@p_cidade", strCidade));
                    oParametros.Add(new SqlParameter("@p_estado", strEstado));

                    //Verificamos se o cliente é um novo cliente (código = 0)
                    if (intCodigo == 0)
                    {
                        //chamamos o método Executar da Classe AcessoBD para efetuar a gravação do novo registro no
                        //banco de dados e armazenamos o novo código do cliente (primary key)
                        intCodigo = oAcessoBD.Executar(strSql, oParametros);
                    }
                    //ou um cliente já existente (codigo != 0)
                    else
                    {
                        //chamamos o método Executar da Classe AcessoBD para efetuar a alteração do cliente no banco de dados
                        oAcessoBD.Executar(strSql, oParametros);
                    }
                    //Montamos a query para apagar todos os telefones do cliente
                    strSql = "Delete from tb_telefone_tel where cli_codigo = @p_codigo";
                    //Limpamos a lista de parâmetros SQL
                    oParametros.Clear();
                    //Adicionamos o código do cliente (foreign key) a lista de parâmetros SQL
                    oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                    //chamamos o método Executar da Classe AcessoBD para efetuar a exclusão dos telefones 
                    //do cliente no banco de dados
                    oAcessoBD.Executar(strSql, oParametros);
                    //Percorremos cada um dos telefones existentes na lista de telefones
                    foreach (string tel in strTelefones)
                    {
                        //Limpamos a lista de parâmetros SQL
                        oParametros.Clear();
                        //Montamos a query de insert no banco de dados
                        strSql = "insert into tb_telefone_tel (tel_numero, cli_codigo) values\n";
                        strSql += "(@p_numero, @p_codigo)";
                        //Adicionamos o número de telefone como parâmetro SQL
                        oParametros.Add(new SqlParameter("@p_numero", tel));
                        //Adicionamos o código do cliente (foreign key) a lista de parâmetros SQL
                        oParametros.Add(new SqlParameter("@p_codigo", intCodigo));
                        //chamamos o método Executar da Classe AcessoBD para efetuar a inclusão dos telefones
                        //do cliente no banco de dados
                        oAcessoBD.Executar(strSql, oParametros);
                    }
                    //Efetivamos a transação (commit), finalizando o processo no banco de dados com sucesso
                    //Caso ocorresse algum erro e a transação não fosse completada, todo o processo de gravação
                    //seria cancelado e desfeito (RollBack)
                    transacao.Complete();
                }
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
