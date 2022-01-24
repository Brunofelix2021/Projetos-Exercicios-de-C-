using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ERP_Senac
{
    class AcessoBD
    {
        SqlConnection oConn;
        private void Conectar()
        {
            try
            {
                oConn = new SqlConnection(Global.strConexao);
                oConn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void Desconectar()
        {
            try
            {
                if (oConn.State == ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarSQL
            (string strSql,List<SqlParameter> param)
        {
            try
            {
                this.Conectar();
                SqlCommand oCmd = new SqlCommand(strSql, oConn);
                foreach (SqlParameter p in param)
                {
                    oCmd.Parameters.Add(p);
                }
                DataSet ds = new DataSet();
                SqlDataAdapter oAdp = new SqlDataAdapter(oCmd);
                oAdp.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.Desconectar();
            }
        }

        public int ExecutarSQL
            (string strSql, List<SqlParameter> param)
        {
            int intRetorno = 0;
            try
            {
                this.Conectar();
                SqlCommand oCmd = new SqlCommand(strSql, oConn);
                foreach (SqlParameter p in param)
                {
                    oCmd.Parameters.Add(p);
                }
                intRetorno = Convert.ToInt32(oCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.Desconectar();
            }
            return intRetorno;
        }

    }
}
