using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ERP_Senac
{
    public static class Global
    {
        public static string strConexao;
        public static int intCodigoUsuario;
        public static string strNomeUsuario;
        public static void LerAppConfig()
        {
            strConexao = string.Format(
                "Data Source={0};Initial Catalog={1};Integrated Security=true;",
                ConfigurationManager.AppSettings["servidor"],
                ConfigurationManager.AppSettings["banco"]);
        }

    }
}
